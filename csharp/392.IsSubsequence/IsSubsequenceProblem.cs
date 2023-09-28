internal class IsSubsequenceProblem
{
    public void Test()
    {
        Console.WriteLine(IsSubsequence("abc", "ahbgdc"));
        Console.WriteLine(IsSubsequence("axc", "ahbgdc"));
    }

    private bool IsSubsequence(string s, string t) {
        int sPtr = 0, tPtr = 0;
        while (sPtr < s.Length && tPtr < t.Length)
        {
            if (s[sPtr] == t[tPtr])
            {
                sPtr++;
            }
            tPtr++;
        }
        return sPtr == s.Length;
    }
}