# 28. Find the Index of the First Occurrence in a String
# Easy
# Given two strings needle and haystack, return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.

# Example 1:
# Input: haystack = "sadbutsad", needle = "sad"
# Output: 0
# Explanation: "sad" occurs at index 0 and 6.
# The first occurrence is at index 0, so we return 0.

# Example 2:
# Input: haystack = "leetcode", needle = "leeto"
# Output: -1
# Explanation: "leeto" did not occur in "leetcode", so we return -1.

# Constraints:
# 1 <= haystack.length, needle.length <= 104
# haystack and needle consist of only lowercase English characters.

# Thinking out loud on a solution...
# - Seems like there's an algorithmic trick involved
# - Need to be prepared for the worst-case scenarios of a long string of repeating characters
#     with a single character mismatch at the end which would cause us to iterate over the input repeatedly

# Let's loop through haystack with an input ptr i
# Let's use a second ptr j to track the first idx of haystack matching the first idx of needle
# When we match the len of needle, we return j
# When we find a mismatch, we reset i to j + 1

# Took two tries because of a logical error on my first solution
# ~25 minute solution start to finish
# Runtime beats 100%, memory beats 96.60%

class Solution:
    def strStr(self, haystack: str, needle: str) -> int:
        i = 0
        needleIdx = 0
        j = -1
        while (i < len(haystack)):
            if (haystack[i] == needle[needleIdx]):
                if j == -1:
                    j = i
                needleIdx += 1
                if (needleIdx == len(needle)):
                    return j
            else:
                if j != -1:
                    i = j
                j = -1
                needleIdx = 0
            i += 1
        return -1


if __name__ == "__main__":
    s = Solution()
    print(s.strStr("sadbutsad", "sad"))  # Expected: "0"
    print(s.strStr("leetcode", "leeto")) # Expected: "-1"
    print(s.strStr("sadbutsad", "s"))  # Expected: "0"
    print(s.strStr("asadbutsad", "s"))  # Expected: "1"
    print(s.strStr("mississippi", "issip"))  # Expected: "4"