internal class FirstSubstrOccurrenceSolution
{
    public void Test()
    {
        Console.WriteLine($"Expect {StrStr("a", "a")} to be 0");
        Console.WriteLine($"Expect {StrStr("sadbutsad", "sad")} to be 0");
        Console.WriteLine($"Expect {StrStr("leetcode", "leeto")} to be -1");
        Console.WriteLine($"Expect {StrStr("leetcode", "code")} to be 4");
        Console.WriteLine($"Expect {StrStr("leetcode", "l")} to be 0");
        Console.WriteLine($"Expect {StrStr("mississippi", "issip")} to be 4");
    }

    public int StrStr(string haystack, string needle) {
        var firstIdxs = new List<int>();
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[0])
            {
                firstIdxs.Add(i);
            }
            
            var idxToRemove = new List<int>();
            foreach(var idx in firstIdxs)
            {
                var needleIdx = i - idx;
                if (haystack[i] != needle[needleIdx])
                {
                    idxToRemove.Add(idx);
                }
                else if (needleIdx == needle.Length - 1)
                {
                    return idx;
                }
                
            }
            idxToRemove.ForEach(idx => firstIdxs.Remove(idx));
        }

        return -1;
    }
}