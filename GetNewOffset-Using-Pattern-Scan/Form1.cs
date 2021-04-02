using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetNewOffset_Using_Pattern_Scan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Label SetPlaceholder(Control control, string text)
        {
            bool Visible = true;
            if (!string.IsNullOrWhiteSpace(control.Text))
            {
                Visible = false;
            }
            var placeholder = new Label
            {
                Text = text,
                Font = control.Font,
                ForeColor = Color.Silver,
                BackColor = Color.FromArgb(45, 45, 45),
                Cursor = Cursors.IBeam,
                Margin = Padding.Empty,

                //get rid of the left margin that all labels have
                FlatStyle = FlatStyle.System,
                AutoSize = false,
                Visible = Visible,

                //Padding = new Padding(control.Padding.Left, control.Padding.Top + 50, control.Padding.Right, control.Padding.Bottom),
                //TextAlign = ContentAlignment.BottomLeft,

                //Leave 1px on the left so we can see the blinking cursor
                Size = new Size(control.Size.Width - 10, control.Size.Height - 5),
                Location = new Point(control.Location.X + 5, control.Location.Y + 3)
            };

            //when clicking on the label, pass focus to the control
            placeholder.Click += (sender, args) => { control.Focus(); };

            //disappear when the user starts typing
            control.TextChanged += (sender, args) => {
                placeholder.Visible = string.IsNullOrEmpty(control.Text);
            };

            //stay the same size/location as the control
            EventHandler updateSize = (sender, args) =>
            {
                placeholder.Location = new Point(control.Location.X + 1, control.Location.Y);
                placeholder.Size = new Size(control.Size.Width - 1, control.Size.Height);
            };

            control.SizeChanged += updateSize;
            control.LocationChanged += updateSize;

            control.Parent.Controls.Add(placeholder);
            placeholder.BringToFront();

            return placeholder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetPlaceholder(this.textBox3, "FF ?? ?? 06 00 ?? E1 00 20 ?? ?? 9D ?? FA EB 03 00 00 ?? 80 01 83 ?? 04");

            this.SetPlaceholder(this.textBox4, "00 06 FF E1 00 20 00 00 FA E1 01");

            this.buttonSelectTextFiles.Enabled = false;
            this.textBox2.Enabled = false;
        }

        private void buttonSelectBinaryFiles_Click(object sender, EventArgs e)
        {
            // Select Binary Files
            this.SelectFiles(this.textBox1, false);
        }

        private void buttonSelectTextFiles_Click(object sender, EventArgs e)
        {
            // Select Text Files
            this.SelectFiles(this.textBox2, true);
        }

        private void SelectFiles(Control textbox, bool TextFiles)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "";
            if(TextFiles)
            {
                openFileDialog.Filter = "Select Text files|*.txt";
            }
            else
            {
                openFileDialog.Filter = "Select Binary Files|*.*";
            }
            DialogResult res = openFileDialog.ShowDialog();
            if (res == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                textbox.Text = openFileDialog.FileName;
            }
        }
        
        private void checkBoxScanAllAOB_in_TextFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxScanAllAOB_in_TextFiles.Checked)
            {
                this.buttonSelectTextFiles.Enabled = true;
                this.textBox2.Enabled = true;
                this.textBox3.Enabled = false;
            }
            else
            {
                this.buttonSelectTextFiles.Enabled = false;
                this.textBox2.Enabled = false;
                this.textBox3.Enabled = true;
            }
        }
        
        private void buttonScan_Click(object sender, EventArgs e)
        {
            try
            {
                Duplicates = string.Empty;
                this.dataGridView1.Rows.Clear();
                this.richTextBox2.Text = string.Empty;
                this.NewOffset = string.Empty;
                this.NewHexCode = string.Empty;
                this.CheckOffset.Clear();


                if (this.checkBoxScanAllAOB_in_TextFiles.Checked)
                {
                    string[] AllAOB = File.ReadAllLines(this.textBox2.Text);
                    //string[] AllAOB1 = File.ReadAllLines(this.textBox1.Text);
                    for (int i = 0; i < AllAOB.Length; i++)
                    {
                        bool result1 = false;
                        this.PatternScan(this.textBox1.Text, AllAOB[i]);
                        for (int k = 0; k < CheckOffset.Count; k++)
                        {
                            if (CheckOffset[k] == this.NewOffset)
                            {
                                result1 = true;
                                //richTextBox2.AppendText("Found Duplicates\n");
                                break;
                            }
                        }
                        if (!result1)
                        {
                            int count = this.dataGridView1.RowCount;
                            string[] row = { count.ToString(), this.NewOffset, this.NewHexCode };
                            this.dataGridView1.Rows.Add(row);
                            this.CheckOffset.Add(this.NewOffset);

                            // Log
                            this.richTextBox2.AppendText("New Offset: " + this.NewOffset + "\n");
                            this.richTextBox2.AppendText("New AOB/HEX Code: " + this.NewHexCode + "\n");
                        }
                        result1 = false;
                    }

                }
                else
                {
                    this.PatternScan(this.textBox1.Text, this.textBox3.Text);

                    int count = this.dataGridView1.RowCount;
                    string[] row = { count.ToString(), this.NewOffset, this.NewHexCode };
                    this.dataGridView1.Rows.Add(row);

                    // Log
                    this.richTextBox2.AppendText("New Offset: " + this.NewOffset + "\n");
                    this.richTextBox2.AppendText("New AOB/HEX Code: " + this.NewOffset + "\n");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Mika Cybertron", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.richTextBox2.AppendText(Error.Message + "\n");
            }
            
        }


        private void buttonCreateHeaderFiles_Click(object sender, EventArgs e)
        {
            if(this.dataGridView1.Rows.Count != 0)
            {
                string GetNewOffset = string.Empty;
                string GetNewHEX = string.Empty;
                using (TextWriter tw = new StreamWriter("AOB.h"))
                {
                    for (int i = 0; i < this.dataGridView1.Rows.Count - 1; i++)
                    {
                        int count = i + 1;
                        GetNewOffset += string.Join("", new string[]
                        {
                            "    uintptr_t NewOffsets" + count + " = " + this.dataGridView1.Rows[i].Cells[1].Value.ToString() + ";\n",
                        });

                        GetNewHEX += string.Join("", new string[]
                        {
                            "    const char* NewHexCode" + count + " = \"" + this.dataGridView1.Rows[i].Cells[2].Value.ToString() + "\";\n\n",
                        });
                    }

                    tw.WriteLine(string.Join("", new string[]
                    {
                        "#ifndef ANDROID_AOB_H\n",
                        "#define ANDROID_AOB_H\n\n",

                        "struct {\n\n",
                        GetNewOffset,
                        "} Offset;\n\n\n",

                        "struct {\n\n",
                        GetNewHEX,
                        "} HEX;\n\n\n",

                        "#endif",
                    }));
                }
                MessageBox.Show("Header Offset has been Created!", "Mika Cybertron", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("There is No Items in the list!", "Mika Cybertron", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void buttonADDAOB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.textBox4.Text) && !string.IsNullOrWhiteSpace(this.textBox4.Text))
            {
                DialogResult Message = MessageBox.Show("Add this AOB to the List?", "Mika Cybertron", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (Message == DialogResult.OK)
                {
                    this.listBox1.Items.Add(this.InsertSpaces(AOB.Format(this.textBox4.Text)));
                    this.textBox4.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("The TextBox is Empty!", "Mika Cybertron", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCreateAOBSignature_Click(object sender, EventArgs e)
        {
            this.SignatureMaker();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count != 0)
            {
                this.listBox1.Items.Clear();
                this.richTextBox1.Text = string.Empty;
            }
        }

        private void buttonRemoveList_Click(object sender, EventArgs e)
        {
            if (this.listBox1.Items.Count != 0)
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox1);
                selectedItems = this.listBox1.SelectedItems;
                int c = this.listBox1.Items.Count - 1;
                if (listBox1.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                    {
                        this.listBox1.Items.Remove(selectedItems[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("There is No Items in ListBox to Removed!", "Mika Cybertron", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.richTextBox1.Text))
            {
                MessageBox.Show("AOB Signature List has been Created!", "Mika Cybertron", MessageBoxButtons.OK, MessageBoxIcon.Information);
                using (TextWriter tw = new StreamWriter("AOB-List.txt"))
                {
                    tw.WriteLine(this.richTextBox1.Text);
                }
            }
            else
            {
                MessageBox.Show("The RichTextBox is Empty!", "Mika Cybertron", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }



        #region Scan & Generate New Offset and New AOB
        // Pattern Scan
        public long RealOffsets = 0;
        private byte[] OriginalHex;
        private string Duplicates = string.Empty;

        private string NewOffset = string.Empty;
        private string NewHexCode = string.Empty;
        private List<string> CheckOffset = new List<string>();
        public void PatternScan(string fileName, string ScanAOB)
        {
            try
            {
                this.RealOffsets = 0;
                this.OriginalHex = null;
                this.NewOffset = string.Empty;
                this.NewHexCode = string.Empty;

                this.OriginalHex = this.ReadFile(fileName);
                var signatures = new[]
                {
                    new AOBSignature("New Offsets", ScanAOB.Replace(" ", "")),
                };

                var result = AOB.Scan(this.ReadFile(fileName), signatures);
                //foreach(var Signature in result)
                for (int i = 0; i < result.Length; i++)
                {
                    // New Offsets
                    this.RealOffsets = result[i].FoundOffset;
                    
                    // New Hex Code
                    StringBuilder originalBytes = new StringBuilder();
                    if (this.OriginalHex != null)
                    {
                        if (this.RealOffsets > 0)
                        {
                            string array = ScanAOB.Replace(" ", "");
                            int InitArray = array.Length / 2;
                            for (int k = (int)this.RealOffsets; k < (int)this.RealOffsets + InitArray; k++)
                            {
                                originalBytes.Append(this.OriginalHex[k].ToString("X2") + " ");
                            }
                        }
                    }

                    this.NewOffset = "0x" + result[i].FoundOffset.ToString("X");
                    this.NewHexCode = originalBytes.ToString().TrimEnd(' ');
                }

            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Mika Cybertron", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.richTextBox2.AppendText(Error.Message + "\n");
            }
        }

        private byte[] ReadFile(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            int length = Convert.ToInt32(fs.Length);
            byte[] data = new byte[length];
            fs.Read(data, 0, length);
            fs.Close();
            return data;
        }

        private byte[] HexStringtoBytes(string szPattern)
        {
            List<byte> patternbytes = new List<byte>();

            foreach (var szByte in szPattern.Split(' '))
                patternbytes.Add(szByte == "?" ? (byte)0x0 : Convert.ToByte(szByte, 16));

            return patternbytes.ToArray();
        }

        #endregion


        #region Create AOB Signature
        // AOB Signature Maker
        public static string[] aob1;
        public static string[] aob2;
        public static string[] aobTemp;
        public static string[] aobOutput;

        public void SignatureMaker()
        {
            try
            {
                int length = this.listBox1.Items[0].ToString().Length;
                Form1.aob1 = new string[length];
                Form1.aob2 = new string[length];
                this.richTextBox1.Text = "";
                Form1.aob1 = this.listBox1.Items[0].ToString().Split(new char[]
                {
                    ' '
                });
                Form1.aob2 = this.listBox1.Items[1].ToString().Split(new char[]
                {
                    ' '
                });
                Form1.aobTemp = new string[Form1.aob1.Length];
                Form1.aobOutput = new string[Form1.aob1.Length];
                for (int i = 0; i < Form1.aob1.Length; i++)
                {
                    if (Form1.aob1[i] != Form1.aob2[i])
                    {
                        Form1.aobOutput[i] = "?? ";
                        Form1.aobTemp[i] = "??";
                    }
                    else
                    {
                        Form1.aobOutput[i] = Form1.aob1[i] + " ";
                        Form1.aobTemp[i] = Form1.aob1[i];
                    }
                }
                for (int j = 0; j < this.listBox1.Items.Count; j++)
                {
                    Form1.aob1 = this.listBox1.Items[j].ToString().Split(new char[]
                    {
                    ' '
                    });
                    for (int k = 0; k < Form1.aob1.Length; k++)
                    {
                        if (Form1.aob1[k] != Form1.aobTemp[k])
                        {
                            Form1.aobOutput[k] = "?? ";
                            Form1.aobTemp[k] = "??";
                        }
                        else
                        {
                            Form1.aobOutput[k] = Form1.aob1[k] + " ";
                            Form1.aobTemp[k] = Form1.aob1[k];
                        }
                    }
                }
                foreach (string str in Form1.aobOutput)
                {
                    this.richTextBox1.Text += str;
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "Mika Cybertron", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.richTextBox2.AppendText(Error.Message + "\n");
            }
        }

        public string InsertSpaces(string s)
        {
            if (!s.Contains(' '))
            {
                for (int i = 2; i <= s.Length; i += 2)
                {
                    s = s.Insert(i, " ");
                    s = s.TrimEnd(' ');
                    i++;
                }

            }
            return s;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Text = string.Empty;
        }
    }
}
