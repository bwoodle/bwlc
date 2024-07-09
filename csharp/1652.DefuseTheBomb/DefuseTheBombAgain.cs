internal class DefuseTheBombAgain
{
    public void Test()
    {
        WriteOutput(Decrypt(new int[] { 5, 7, 1, 4 }, 3));
        WriteOutput(Decrypt(new int[] { 1, 2, 3, 4 }, 0));
        WriteOutput(Decrypt(new int[] { 2, 4, 9, 3 }, -2));
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
    /*
You have a bomb to defuse, and your time is running out! Your informer will provide you with a circular array code of length of n and a key k.

To decrypt the code, you must replace every number. All the numbers are replaced simultaneously.

If k > 0, replace the ith number with the sum of the next k numbers.
If k < 0, replace the ith number with the sum of the previous k numbers.
If k == 0, replace the ith number with 0.
As code is circular, the next element of code[n-1] is code[0], and the previous element of code[0] is code[n-1].

Given the circular array code and an integer key k, return the decrypted code to defuse the bomb!
    */
        var rval = new int[code.Length];
        if (k > 0)
        {
            var currentSum = 0;
            for (int i = 1; i <= k; i++)
            {
                currentSum += code[i % code.Length];
            }
            for (int i = 0; i < code.Length; i++)
            {
                rval[i] = currentSum;
                currentSum = currentSum - code[(i+1) % code.Length] + code[(i + k + 1) % code.Length];
            }
        }
        else if (k < 0)
        {
            var currentSum = 0;
            for (int i = 1; i <= k*-1; i++)
            {
                currentSum += code[code.Length - i];
            }
            for (int i = 0; i < code.Length; i++)
            {
                rval[i] = currentSum;
                currentSum = currentSum + code[i] - code[(code.Length + k + i) % code.Length];
            }
        }

        return rval;
    }
}