internal class LongestSubstringSecontTry
{
    public void Test()
    {
        Console.WriteLine($"Expect {LengthOfLongestSubstring("cdd")} to be 2"); // 2
        Console.WriteLine($"Expect {LengthOfLongestSubstring("abc")} to be 3"); // 3
        Console.WriteLine($"Expect {LengthOfLongestSubstring("aab")} to be 2"); // 2
        Console.WriteLine($"Expect {LengthOfLongestSubstring("abcabcbb")} to be 3"); // 3
        Console.WriteLine($"Expect {LengthOfLongestSubstring("bbbbb")} to be 1"); // 1
        Console.WriteLine($"Expect {LengthOfLongestSubstring("pwwkew")} to be 3"); // 3
        Console.WriteLine($"Expect {LengthOfLongestSubstring("dvdf")} to be 3"); // 3
        Console.WriteLine($"Expect {LengthOfLongestSubstring("abba")} to be 2"); // 2
    }

    public int LengthOfLongestSubstring(string s) {
        // Plan: One pass, store idx of each character in a hashmap
        // Conflict requires us to record the length of the current substring, reset the starting point
        var longestSeen = 0;
        var currentSubstringLength = 0;
        var characterLocation = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++)
        {
            if (characterLocation.ContainsKey(s[i]) && characterLocation[s[i]] >= i - currentSubstringLength)
            {
                if (currentSubstringLength > longestSeen)
                {
                    longestSeen = currentSubstringLength;
                }
                currentSubstringLength = i - characterLocation[s[i]] - 1;
                characterLocation[s[i]] = i;
            }
            else
            {
                characterLocation[s[i]] = i;
            }
            currentSubstringLength++;
        }

        return currentSubstringLength > longestSeen ? currentSubstringLength : longestSeen;
    }
}