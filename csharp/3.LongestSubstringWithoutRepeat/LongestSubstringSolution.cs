using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

internal class LongestSubstringSolution
{
    public void Test()
    {
        Console.WriteLine(LengthOfLongestSubstring("cdd")); // 2
        Console.WriteLine(LengthOfLongestSubstring("abc")); // 3
        Console.WriteLine(LengthOfLongestSubstring("aab")); // 2
        Console.WriteLine(LengthOfLongestSubstring("abcabcbb")); // 3
        Console.WriteLine(LengthOfLongestSubstring("bbbbb")); // 1
        Console.WriteLine(LengthOfLongestSubstring("pwwkew")); // 3
        Console.WriteLine(LengthOfLongestSubstring("dvdf")); // 3
        Console.WriteLine(LengthOfLongestSubstring("abba")); // 2
    }
 
    public int LengthOfLongestSubstring(string s) {
        /*
            Strategy:
            - One pointer (a) iterating through the indices of letters
            - One pointer (b) at the "beginning" of the current longest substring without repeat
            - When a conflict occurs:
                - Check if the current longest substring is longer than the longest. If so, save its length
                - Reset the (b) pointer to the beginning of the current longest substring
            - GOTCHAS
                - We will use a Hashtable with key = character, value = index. Hash collision tells us there's a conflict
                - We need to validate that the first index of the conflict (the value of the hash table) is > (b). Otherwise,
                  it's a conflict from a prior substring. We could get around this by clearing out the hash table but that
                  increases complexity
        */
        int a = 0;
        int b = 0;
        int longest = 0;
        var ht = new Dictionary<char, int>();
        while (a < s.Length)
        {
            if (ht.ContainsKey(s[a]) && ht[s[a]] >= b)
            {
                if (a - b > longest)
                {
                    longest = a - b;
                }
                b = ht[s[a]] + 1;
            }
            ht[s[a]] = a++;
        }
        if (a - b > longest)
        {
            longest = a - b;
        }
        return longest;
    }
}