using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class RomanToIntSolution
{
    public void Test()
    {
        Console.WriteLine(RomanToInt("III"));
        Console.WriteLine(RomanToInt("LVIII"));
        Console.WriteLine(RomanToInt("MCMXCIV"));
    }

    public int RomanToInt(string s)
    {
        var rval = 0;
        var ptr = 0;
        while (ptr < s.Length)
        {
            if (s[ptr] == 'I')
            {
                if (ptr + 1 < s.Length && s[ptr + 1] == 'V')
                {
                    rval += 4;
                    ptr += 2;
                }
                else if (ptr + 1 < s.Length && s[ptr + 1] == 'X')
                {
                    rval += 9;
                    ptr += 2;
                }
                else
                {
                    rval += 1;
                    ptr++;
                }
            }
            else if (s[ptr] == 'X')
            {
                if (ptr + 1 < s.Length && s[ptr + 1] == 'L')
                {
                    rval += 40;
                    ptr += 2;
                }
                else if (ptr + 1 < s.Length && s[ptr + 1] == 'C')
                {
                    rval += 90;
                    ptr += 2;
                }
                else
                {
                    rval += 10;
                    ptr++;
                }
            }
            else if (s[ptr] == 'C')
            {
                if (ptr + 1 < s.Length && s[ptr + 1] == 'D')
                {
                    rval += 400;
                    ptr += 2;
                }
                else if (ptr + 1 < s.Length && s[ptr + 1] == 'M')
                {
                    rval += 900;
                    ptr += 2;
                }
                else
                {
                    rval += 100;
                    ptr++;
                }
            }
            else if (s[ptr] == 'V')
            {
                rval += 5;
                ptr++;
            }
            else if (s[ptr] == 'L')
            {
                rval += 50;
                ptr++;
            }
            else if (s[ptr] == 'D')
            {
                rval += 500;
                ptr++;
            }
            else if (s[ptr] == 'M')
            {
                rval += 1000;
                ptr++;
            }
        }
        return rval;
    }
}
