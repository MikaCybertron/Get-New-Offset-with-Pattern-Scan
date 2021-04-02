namespace GetNewOffset_Using_Pattern_Scan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonCreateHeaderFiles = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonScan = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSelectTextFiles = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxScanAllAOB_in_TextFiles = new System.Windows.Forms.CheckBox();
            this.buttonSelectBinaryFiles = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonRemoveList = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonCreateAOBSignature = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonADDAOB = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 421);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage1.Controls.Add(this.buttonCreateHeaderFiles);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.buttonScan);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.buttonSelectTextFiles);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.checkBoxScanAllAOB_in_TextFiles);
            this.tabPage1.Controls.Add(this.buttonSelectBinaryFiles);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(601, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Scan AOB";
            // 
            // buttonCreateHeaderFiles
            // 
            this.buttonCreateHeaderFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateHeaderFiles.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCreateHeaderFiles.Location = new System.Drawing.Point(9, 361);
            this.buttonCreateHeaderFiles.Name = "buttonCreateHeaderFiles";
            this.buttonCreateHeaderFiles.Size = new System.Drawing.Size(584, 25);
            this.buttonCreateHeaderFiles.TabIndex = 11;
            this.buttonCreateHeaderFiles.Text = "Create Header Offset";
            this.buttonCreateHeaderFiles.UseVisualStyleBackColor = true;
            this.buttonCreateHeaderFiles.Click += new System.EventHandler(this.buttonCreateHeaderFiles_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(9, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(584, 186);
            this.dataGridView1.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.FillWeight = 35F;
            this.Column1.HeaderText = "No.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 45;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 35F;
            this.Column2.HeaderText = "New Offsets";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 35F;
            this.Column3.HeaderText = "NEW AOB/HEX";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 340;
            // 
            // buttonScan
            // 
            this.buttonScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScan.ForeColor = System.Drawing.Color.DeepPink;
            this.buttonScan.Location = new System.Drawing.Point(9, 133);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(584, 30);
            this.buttonScan.TabIndex = 9;
            this.buttonScan.Text = "Scan && Generate New Offsets and New AOB/HEX";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBox3.ForeColor = System.Drawing.Color.Yellow;
            this.textBox3.Location = new System.Drawing.Point(100, 96);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(493, 23);
            this.textBox3.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Array of Bytes:";
            // 
            // buttonSelectTextFiles
            // 
            this.buttonSelectTextFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectTextFiles.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSelectTextFiles.Location = new System.Drawing.Point(518, 40);
            this.buttonSelectTextFiles.Name = "buttonSelectTextFiles";
            this.buttonSelectTextFiles.Size = new System.Drawing.Size(75, 25);
            this.buttonSelectTextFiles.TabIndex = 6;
            this.buttonSelectTextFiles.Text = "Select";
            this.buttonSelectTextFiles.UseVisualStyleBackColor = true;
            this.buttonSelectTextFiles.Click += new System.EventHandler(this.buttonSelectTextFiles_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBox2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(83, 42);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(429, 23);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text Files:";
            // 
            // checkBoxScanAllAOB_in_TextFiles
            // 
            this.checkBoxScanAllAOB_in_TextFiles.AutoSize = true;
            this.checkBoxScanAllAOB_in_TextFiles.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.checkBoxScanAllAOB_in_TextFiles.Location = new System.Drawing.Point(8, 72);
            this.checkBoxScanAllAOB_in_TextFiles.Name = "checkBoxScanAllAOB_in_TextFiles";
            this.checkBoxScanAllAOB_in_TextFiles.Size = new System.Drawing.Size(213, 19);
            this.checkBoxScanAllAOB_in_TextFiles.TabIndex = 3;
            this.checkBoxScanAllAOB_in_TextFiles.Text = "Scan All Array of Bytes in Text Files";
            this.checkBoxScanAllAOB_in_TextFiles.UseVisualStyleBackColor = true;
            this.checkBoxScanAllAOB_in_TextFiles.CheckedChanged += new System.EventHandler(this.checkBoxScanAllAOB_in_TextFiles_CheckedChanged);
            // 
            // buttonSelectBinaryFiles
            // 
            this.buttonSelectBinaryFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectBinaryFiles.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonSelectBinaryFiles.Location = new System.Drawing.Point(518, 9);
            this.buttonSelectBinaryFiles.Name = "buttonSelectBinaryFiles";
            this.buttonSelectBinaryFiles.Size = new System.Drawing.Size(75, 25);
            this.buttonSelectBinaryFiles.TabIndex = 2;
            this.buttonSelectBinaryFiles.Text = "Select";
            this.buttonSelectBinaryFiles.UseVisualStyleBackColor = true;
            this.buttonSelectBinaryFiles.Click += new System.EventHandler(this.buttonSelectBinaryFiles_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(83, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 23);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binary Files:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.buttonRemoveList);
            this.tabPage2.Controls.Add(this.buttonClearAll);
            this.tabPage2.Controls.Add(this.buttonCreateAOBSignature);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.buttonADDAOB);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(601, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create AOB Signature";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button5.Location = new System.Drawing.Point(366, 363);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(227, 25);
            this.button5.TabIndex = 10;
            this.button5.Text = "Write All AOB Signature to Text Files";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(6, 215);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(587, 142);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // buttonRemoveList
            // 
            this.buttonRemoveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveList.ForeColor = System.Drawing.Color.Red;
            this.buttonRemoveList.Location = new System.Drawing.Point(443, 184);
            this.buttonRemoveList.Name = "buttonRemoveList";
            this.buttonRemoveList.Size = new System.Drawing.Size(150, 25);
            this.buttonRemoveList.TabIndex = 8;
            this.buttonRemoveList.Text = "Remove Selected List";
            this.buttonRemoveList.UseVisualStyleBackColor = true;
            this.buttonRemoveList.Click += new System.EventHandler(this.buttonRemoveList_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearAll.ForeColor = System.Drawing.Color.Red;
            this.buttonClearAll.Location = new System.Drawing.Point(274, 184);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(150, 25);
            this.buttonClearAll.TabIndex = 7;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // buttonCreateAOBSignature
            // 
            this.buttonCreateAOBSignature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateAOBSignature.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonCreateAOBSignature.Location = new System.Drawing.Point(6, 184);
            this.buttonCreateAOBSignature.Name = "buttonCreateAOBSignature";
            this.buttonCreateAOBSignature.Size = new System.Drawing.Size(174, 25);
            this.buttonCreateAOBSignature.TabIndex = 6;
            this.buttonCreateAOBSignature.Text = "Create AOB Signature";
            this.buttonCreateAOBSignature.UseVisualStyleBackColor = true;
            this.buttonCreateAOBSignature.Click += new System.EventHandler(this.buttonCreateAOBSignature_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBox1.ForeColor = System.Drawing.Color.Lime;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(6, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(587, 139);
            this.listBox1.TabIndex = 5;
            // 
            // buttonADDAOB
            // 
            this.buttonADDAOB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonADDAOB.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonADDAOB.Location = new System.Drawing.Point(462, 9);
            this.buttonADDAOB.Name = "buttonADDAOB";
            this.buttonADDAOB.Size = new System.Drawing.Size(131, 25);
            this.buttonADDAOB.TabIndex = 4;
            this.buttonADDAOB.Text = "Add Array of Bytes";
            this.buttonADDAOB.UseVisualStyleBackColor = true;
            this.buttonADDAOB.Click += new System.EventHandler(this.buttonADDAOB_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.textBox4.ForeColor = System.Drawing.Color.Yellow;
            this.textBox4.Location = new System.Drawing.Point(6, 11);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(450, 23);
            this.textBox4.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(601, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log Output";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.richTextBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.richTextBox2.Location = new System.Drawing.Point(12, 47);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(576, 332);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(12, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(576, 25);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear Log Output";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(629, 437);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get New Offset Using Pattern Scan or AOB Signature";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSelectTextFiles;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxScanAllAOB_in_TextFiles;
        private System.Windows.Forms.Button buttonSelectBinaryFiles;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonCreateHeaderFiles;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonRemoveList;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonCreateAOBSignature;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonADDAOB;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

