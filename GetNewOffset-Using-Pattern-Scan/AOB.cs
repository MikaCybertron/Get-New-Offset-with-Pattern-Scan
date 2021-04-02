using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetNewOffset_Using_Pattern_Scan
{
    public static class AOB
    {
        public struct Byte
        {
            public struct Nibble
            {
                public bool Wildcard;
                public byte Data;
            }

            public Nibble N1;
            public Nibble N2;
        }

        public static IEnumerable<long> FindPattern(byte[] pattern, byte[] data)
        {
            Queue<byte> queue = new Queue<byte>(pattern.Length);
            using (MemoryStream input = new MemoryStream(data))
            using (BinaryReader reader = new BinaryReader(input))
            {
                byte[] buffer = new byte[1];
                while (1 == reader.Read(buffer, 0, 1))
                {
                    if (queue.Count == pattern.Length)
                    {
                        queue.Dequeue();
                    }

                    queue.Enqueue(buffer[0]);
                    if (Matches(queue, pattern))
                    {
                        // The input is positioned after the last read byte, which
                        // completed the pattern.
                        yield return input.Position;
                    }
                }
            }
        }

        private static bool Matches(Queue<byte> data, byte[] pattern)
        {
            return data.SequenceEqual(pattern);
        }

        public static string Format(string pattern)
        {
            var length = pattern.Length;
            var result = new StringBuilder(length);
            for (var i = 0; i < length; i++)
            {
                var ch = pattern[i];
                if (ch >= '0' && ch <= '9' || ch >= 'A' && ch <= 'F' || ch >= 'a' && ch <= 'f' || ch == '?')
                    result.Append(ch);
            }
            return result.ToString();
        }

        private static int hexChToInt(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return ch - '0';
            if (ch >= 'A' && ch <= 'F')
                return ch - 'A' + 10;
            if (ch >= 'a' && ch <= 'f')
                return ch - 'a' + 10;
            return -1;
        }

        public static Byte[] Transform(string pattern)
        {
            pattern = Format(pattern);
            var length = pattern.Length;
            if (length == 0)
                return null;
            var result = new List<Byte>((length + 1) / 2);
            if (length % 2 != 0)
            {
                if (pattern.Contains("?"))
                {
                    pattern += "?";
                }
                else if (pattern.Contains("X"))
                {
                    pattern += "X";
                }
                length++;
            }
            var newbyte = new Byte();
            for (int i = 0, j = 0; i < length; i++)
            {
                var ch = pattern[i];
                if (ch == '?') // wildcard '?'
                {
                    if (j == 0)
                        newbyte.N1.Wildcard = true;
                    else
                        newbyte.N2.Wildcard = true;
                }
                else if (ch == 'X') // wildcard 'x'
                {
                    if (j == 0)
                        newbyte.N1.Wildcard = true;
                    else
                        newbyte.N2.Wildcard = true;
                }
                else // hex
                {
                    if (j == 0)
                    {
                        newbyte.N1.Wildcard = false;
                        newbyte.N1.Data = (byte)(hexChToInt(ch) & 0xF);
                    }
                    else
                    {
                        newbyte.N2.Wildcard = false;
                        newbyte.N2.Data = (byte)(hexChToInt(ch) & 0xF);
                    }
                }

                j++;
                if (j == 2)
                {
                    j = 0;
                    result.Add(newbyte);
                }
            }
            return result.ToArray();
        }

        public static Byte[] Transform1(string pattern)
        {
            pattern = Format(pattern);
            var length = pattern.Length;
            if (length == 0)
                return null;
            var result = new List<Byte>((length + 1) / 2);
            if (length % 2 != 0)
            {
                if (pattern.Contains("X"))
                {
                    pattern += "X";
                }
                length++;
            }
            var newbyte = new Byte();
            for (int i = 0, j = 0; i < length; i++)
            {
                var ch = pattern[i];
                if (ch == 'X') // wildcard 'x'
                {
                    if (j == 0)
                        newbyte.N1.Wildcard = true;
                    else
                        newbyte.N2.Wildcard = true;
                }
                else // hex
                {
                    if (j == 0)
                    {
                        newbyte.N1.Wildcard = false;
                        newbyte.N1.Data = (byte)(hexChToInt(ch) & 0xF);
                    }
                    else
                    {
                        newbyte.N2.Wildcard = false;
                        newbyte.N2.Data = (byte)(hexChToInt(ch) & 0xF);
                    }
                }

                j++;
                if (j == 2)
                {
                    j = 0;
                    result.Add(newbyte);
                }
            }
            return result.ToArray();
        }

        public static bool Find(byte[] data, Byte[] pattern)
        {
            long temp;
            return Find(data, pattern, out temp);
        }

        private static bool matchByte(byte b, ref Byte p)
        {
            if (!p.N1.Wildcard) //if not a wildcard we need to compare the data.
            {
                var n1 = b >> 4;
                if (n1 != p.N1.Data) //if the data is not equal b doesn't match p.
                    return false;
            }
            if (!p.N2.Wildcard) //if not a wildcard we need to compare the data.
            {
                var n2 = b & 0xF;
                if (n2 != p.N2.Data) //if the data is not equal b doesn't match p.
                    return false;
            }
            return true;
        }

        public static bool Find(byte[] data, Byte[] pattern, out long offsetFound, long offset = 0)
        {
            offsetFound = -1;
            if (data == null || pattern == null)
                return false;
            var patternSize = pattern.LongLength;
            if (data.LongLength == 0 || patternSize == 0)
                return false;

            for (long i = offset, pos = 0; i < data.LongLength; i++)
            {
                if (matchByte(data[i], ref pattern[pos])) //check if the current data byte matches the current pattern byte
                {
                    pos++;
                    if (pos == patternSize) //everything matched
                    {
                        offsetFound = i - patternSize + 1;
                        return true;
                    }
                }
                else //fix by Computer_Angel
                {
                    i -= pos;
                    pos = 0; //reset current pattern position
                }
            }

            return false;
        }

        public static bool FindAll(byte[] data, Byte[] pattern, out List<long> offsetsFound)
        {
            offsetsFound = new List<long>();
            long size = data.Length, pos = 0;
            while (size > pos)
            {
                if (Find(data, pattern, out long offsetFound, pos))
                {
                    offsetsFound.Add(offsetFound);
                    pos = offsetFound + pattern.Length;
                }
                else
                    break;
            }
            if (offsetsFound.Count > 0)
                return true;
            else
                return false;
        }

        public static AOBSignature[] Scan(byte[] data, AOBSignature[] signatures)
        {
            var found = new ConcurrentBag<AOBSignature>();
            Parallel.ForEach(signatures, signature =>
            {
                if (Find(data, signature.Pattern1, out signature.FoundOffset))
                    found.Add(signature);
            });
            return found.ToArray();
        }
    }
}
