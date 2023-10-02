public class LongestPalindromicSubstringSolution
{
    // Test results:
    // Run 1 successful on my 4 test cases, leetcode accepted (beats 62.61% runtime, 41.71% memory)
    // Heck yeah!
    public void Test()
    {
        var tc1 = "babad";
        var tc2 = "cbbd";
        var tc3 = "abcdefghgfedcbaaba";
        var tc4 = "abaabcdefghgfedcba";

        Console.WriteLine(LongestPalindrome(tc1)); // bab or aba
        Console.WriteLine(LongestPalindrome(tc2)); // bb
        Console.WriteLine(LongestPalindrome(tc3)); // abcdefghgfedcba
        Console.WriteLine(LongestPalindrome(tc4)); // abcdefghgfedcba
    }
    
    // 1 <= s.length <= 1000
    // only digits and english letters
    // Solution thinking out loud...
    // I've never attempted this problem before, but I did get tripped up on a palindrome problem years ago
    // I could brute force create a stack for every digit - with s <= 1000, that's 1000 (stacks) * 500 (average chars per stack) * 2 (bytes) = 1 MB of memory
    //  But the computational complexity would suck
    // I'll try to think of something more elegant...
    // aha - the trick is to loop through s and treat your pointer i as the middle of a palindrome, counting until i + x != i - x
    // There are two cases - odd length, where s[i] is the center, and even length, where s[i] and s[i+1] are the center
    // I think I need to check both for every i...
    public string LongestPalindrome(string s) {
        string longest = "";
        for (int i = 0; i < s.Length; i++) {
            var pal = CheckEvenPalindrome(s, i);
            if (pal.Length > longest.Length)
            {
                longest = pal;
            }
            pal = CheckOddPalindrome(s, i);
            if (pal.Length > longest.Length)
            {
                longest = pal;
            }
        }
        return longest;
    }

    private string CheckEvenPalindrome(string s, int idx)
    {
        if ((idx + 1) < s.Length && s[idx] == s[idx+1])
        {
            var lowerIdx = idx - 1;
            var upperIdx = idx + 2;
            // Remember - right now upperIdx - lowerIdx = 3, but we've only got a palindrome of 2. We'll need to unwind at the end
            while (lowerIdx >= 0 && upperIdx < s.Length && s[lowerIdx] == s[upperIdx])
            {
                lowerIdx--;
                upperIdx++;
            }
            return s.Substring(lowerIdx + 1, upperIdx - lowerIdx - 1);
        }
        return "";
    }

    private string CheckOddPalindrome(string s, int idx)
    {
        var lowerIdx = idx - 1;
        var upperIdx = idx + 1;
        // Remember - right now upperIdx - lowerIdx = 2, but we've only got a palindrome of 1. We'll need to unwind at the end
        while (lowerIdx >= 0 && upperIdx < s.Length && s[lowerIdx] == s[upperIdx])
        {
            lowerIdx--;
            upperIdx++;
        }
        return s.Substring(lowerIdx + 1, upperIdx - lowerIdx - 1);
    }
}