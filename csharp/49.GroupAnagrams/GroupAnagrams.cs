using System.Collections;

internal class GroupAnagramsSolution
{
    /*
Given an array of strings strs, group the anagrams together. You can return the answer in any order.
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

1 <= strs.length <= 104
0 <= strs[i].length <= 100
strs[i] consists of lowercase English letters.
    */

    public void Test()
    {
        var input = new string[] {"eat","tea","tan","ate","nat","bat"};
        var rval = GroupAnagrams(input);
        Console.WriteLine("Expect [[\"bat\"],[\"nat\",\"tan\"],[\"ate\",\"eat\",\"tea\"]]");
        foreach(var ana in rval)
        {
            foreach(var innerAna in ana)
            {
                Console.Write(innerAna + ", ");
            }
            Console.Write("\r\n");
        }

        
        input = new string[] {"",""};
        rval = GroupAnagrams(input);
        Console.WriteLine("Expect [[\"\",\"\"]");
        foreach(var ana in rval)
        {
            foreach(var innerAna in ana)
            {
                Console.Write(innerAna + ", ");
            }
            Console.Write("\r\n");
        }
    }

    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var rval = new List<IList<string>>();

        foreach(var str in strs)
        {
            bool found = false;
            foreach(var list in rval)
            {
                if(AnagramMatch(str, list[0]))
                {
                    list.Add(str);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                rval.Add(new List<string> {str});
            }
        }

        return rval;
    }

    
    private bool AnagramMatch(string str1, string str2)
    {
        // "" should match ""
        if (str1 == str2)
        {
            return true;
        }
        if (str1.Length != str2.Length)
        {
            return false;
        }
        var chars = str2.ToCharArray().ToList();
        for(int i = 0; i < str1.Length; i++)
        {
            if(!chars.Remove(str1[i]))
            {
                return false;
            }
        }
        return true;
    }

    // Too slow - time limit exceeded
    private bool AnagramMatchOld(string str1, string str2)
    {
        // "" should match ""
        if (str1 == str2)
        {
            return true;
        }
        if (str1.Length != str2.Length)
        {
            return false;
        }

        var dict = new Dictionary<char, int>();
        foreach(var c in str1.ToCharArray())
        {
            if(dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict.Add(c, 1);
            }
        }

        foreach(var c in str2.ToCharArray())
        {
            if (dict.ContainsKey(c) && dict[c] > 0)
            {
                dict[c]--;
            }
            else
            {
                return false;
            }
        }
        if(dict.Values.Any(v => v > 0))
        {
            return false;
        }

        return true;
    }
}