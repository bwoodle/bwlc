using System.Text;

internal class ZigZagConversion
{
/*
The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)

P   A   H   N
A P L S I I G
Y   I   R
And then read line by line: "PAHNAPLSIIGYIR"

Write the code that will take a string and make this conversion given a number of rows:
*/

    public void Test()
    {
        Console.WriteLine($"Expect {Convert("PAYPALISHIRING", 3)} to be \"PAHNAPLSIIGYIR\"");
        Console.WriteLine($"Expect {Convert("PAYPALISHIRING", 4)} to be \"PINALSIGYAHRPI\"");
    }

    public string Convert(string s, int numRows) {
        if (numRows == 1 || s.Length <= numRows)
        {
            return s;
        }

        var rval = new StringBuilder();
        var firstRowGap = (numRows - 1)*2;

        // Row 0
        var idx = 0;
        while (idx < s.Length)
        {
            rval.Append(s[idx]);
            idx += firstRowGap;
        }

        // Middle Rows
        for (int i = 1; i < numRows - 1; i++)
        {
            idx = i;
            rval.Append(s[idx]);
            while (idx < s.Length)
            {
                if (idx + firstRowGap - i*2 < s.Length)
                {
                    rval.Append(s[idx + firstRowGap - i*2]);
                }
                if (idx + firstRowGap < s.Length)
                {
                    rval.Append(s[idx + firstRowGap]);
                }
                idx += firstRowGap;
            }
        }

        // Last Row
        idx = numRows - 1;
        while (idx < s.Length)
        {
            rval.Append(s[idx]);
            idx += firstRowGap;
        }

        return rval.ToString();
    }
}

