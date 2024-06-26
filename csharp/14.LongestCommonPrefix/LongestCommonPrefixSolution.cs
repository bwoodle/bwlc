using System.Security.Cryptography;

internal class LongestCommonPrefixSolution
{

    public void Test()
    {
        Console.WriteLine($"Expect '{LongestCommonPrefix(["flower","flow","flight"])}' to be 'fl'");
        Console.WriteLine($"Expect '{LongestCommonPrefix(["dog","racecar","car"])}' to be ''");
        Console.WriteLine($"Expect '{LongestCommonPrefix(["ab","a"])}' to be 'a'");
    }

    public string LongestCommonPrefix(string[] strs) {
        var rval = "";
        if (strs.Length < 1 || strs.Length > 200 || strs[0].Length > 200)
        {
            return rval;
        }
        for(int i = 0; i < strs[0].Length && i < 200; i++)
        {
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j].Length == i || strs[0][i] != strs[j][i]){
                    return rval;
                }
            }
            rval += strs[0][i];
        }
        return rval;
    }
}