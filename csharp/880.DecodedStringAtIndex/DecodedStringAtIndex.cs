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
            Console.WriteLine(DecodeAtIndex("leet2code3", 10));
            Console.WriteLine(DecodeAtIndex("ha22", 5));
            Console.WriteLine(DecodeAtIndex("a2345678999999999999999", 1));

            // Console.WriteLine(DecodeAtIndex("y959q969u3hb22odq595", 222280369));
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

            for (int j = i - 1; j >= 0; j--)
            {
                if (IsAsciiDigit(s[j]))
                {
                    var num = int.Parse(s[j].ToString());
                    length /= num;
                    k %= (int)length;
                }
                else
                {
                    if (k == 0 || k == length)
                    {
                        return s[j].ToString();
                    }
                    length--;
                }
            }
            return string.Empty;
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
