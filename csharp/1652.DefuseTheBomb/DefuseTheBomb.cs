using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCConsoleApp.DefuseTheBomb
{
    internal class DefuseTheBomb
    {
        public static void Test()
        {
            Solve(new int[] { 5, 7, 1, 4 }, 3);
            Solve(new int[] { 1, 2, 3, 4 }, 0);
            Solve(new int[] { 2, 4, 9, 3 }, -2);
        }

        public static void Solve(int[] code, int k)
        {
            WriteOutput(Decrypt(code, k));
        }

        public static void WriteOutput(int[] res)
        {
            var str = "[";
            res.ToList().ForEach(i => { str += i + ", "; });
            str = str.Substring(0, str.Length - 2);
            str += "]";
            Console.WriteLine(str);
        }

        public static int[] Decrypt(int[] code, int k)
        {
            var rval = new List<int>();
            if (k > 0)
            {
                for (int i = 0; i < code.Length; i++)
                {
                    var idx = k;
                    var curSum = 0;
                    while (idx > 0)
                    {
                        curSum += code[(i + idx--) % code.Length];
                    }
                    rval.Add(curSum);
                }
            }
            else if (k < 0)
            {
                for (int i = 0; i < code.Length; i++)
                {
                    var idx = k;
                    var curSum = 0;
                    while (idx < 0)
                    {
                        var positiveIndex = i + idx++;
                        while (positiveIndex < 0)
                        {
                            positiveIndex += code.Length;
                        }
                        curSum += code[positiveIndex % code.Length];
                    }
                    rval.Add(curSum);
                }
            }
            else
            { // k == 0
                return new int[code.Length];
            }
            return rval.ToArray();
        }
    }
}
