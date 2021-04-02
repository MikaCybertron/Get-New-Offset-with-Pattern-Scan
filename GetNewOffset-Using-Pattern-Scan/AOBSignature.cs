using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetNewOffset_Using_Pattern_Scan
{
    public class AOBSignature
    {
        public AOBSignature(string name, AOB.Byte[] pattern)
        {
            Name = name;
            Pattern1 = pattern;
            FoundNewHex = pattern.ToString();
            FoundOffset = -1;
        }

        public AOBSignature(string name, string pattern)
        {
            Name = name;
            Pattern1 = AOB.Transform(pattern);
            FoundOffset = -1;
        }

        public string Name { get; private set; }
        public AOB.Byte[] Pattern1 { get; private set; }
        public long FoundOffset;
        public string FoundNewHex;


        public override string ToString()
        {
            return Name;
        }
    }
}
