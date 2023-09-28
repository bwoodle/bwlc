using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCConsoleApp._880.DecodedStringAtIndex
{
    internal class DecodedStringAtIndex
    {
        public void Test()
        {
            //Console.WriteLine(DecodeAtIndex("leet2code3", 10));
            //Console.WriteLine(DecodeAtIndex("ha22", 5));
            //Console.WriteLine(DecodeAtIndex("a2345678999999999999999", 1));

            Console.WriteLine(DecodeAtIndex("y959q969u3hb22odq595", 222280369));
        }

        public string DecodeAtIndex(string s, int k)
        {
            long length = 0;
            int i = 0;

            while (length < k) {
                if (IsAsciiDigit(s[i]))
                {
                    var num = int.Parse(s[i].ToString());
                    length *= num;
                }
                else
                {
                    length++;
                }
                i++;
            }

            for (int j = i - 1; j > 0; j--)
            {
                if (IsAsciiDigit(s[i]))
                {
                    k = k % (int)length;
                    var num = int.Parse(s[i].ToString());
                    length /= num;
                }
                else
                {

                }
            }
            return string.Empty;

            /*
            var sIdx = 0;
            var strBuilder = new StringBuilder();
            while (sIdx < s.Length && strBuilder.Length < k)
            {
                if (IsAsciiLetter(s[sIdx]))
                {
                    strBuilder.Append(s[sIdx++]);
                    if (CheckStringLength(strBuilder, k))
                    {
                        return strBuilder[k - 1].ToString();
                    }
                }
                else if (IsAsciiDigit(s[sIdx]))
                {
                    var num = int.Parse(s[sIdx++].ToString());
                    var curStr = strBuilder.ToString();
                    for(int i = 0; i < num - 1; i++)
                    {
                        strBuilder.Append(curStr);
                        if (CheckStringLength(strBuilder, k))
                        {
                            return strBuilder[k - 1].ToString();
                        }
                    }
                }
            }
            return "";
            */
        }

        private bool CheckStringLength(StringBuilder s, int k)
        {
            return s.Length >= k;
        }

        private bool IsAsciiLetter(char c)
        {
            return c >= 97 && c <= 122;
        }

        private bool IsAsciiDigit(char c)
        {
            return c >= 50 && c <= 57;
        }
    }
}
