# Runtime beats 71.2%, Memory beats 8.53%
class Solution:
    def mergeAlternately(self, word1: str, word2: str) -> str:
        rval: str = ""
        onWord1: bool = True
        ptr1: int = 0
        ptr2: int = 0
        while ptr1 < len(word1) or ptr2 < len(word2):
            if (onWord1 and ptr1 < len(word1)):
                rval += word1[ptr1]
                ptr1 += 1
                onWord1 = not onWord1
            elif (not onWord1 and ptr2 < len(word2)):
                rval += word2[ptr2]
                ptr2 += 1
                onWord1 = not onWord1
            else:
                onWord1 = not onWord1
        return rval

if __name__ == "__main__":
    s = Solution()
    print(s.mergeAlternately("abc", "pqr"))  # Expected: "apbqcr"
    print(s.mergeAlternately("ab", "pqrs"))  # Expected: "apbqrs"
    print(s.mergeAlternately("abcd", "pq"))  # Expected: "apbqcd"
    print(s.mergeAlternately("ab", "pqcd"))  # Expected: "apbqcd"
    print(s.mergeAlternately("", "apbqcd"))  # Expected: "apbqcd"
    print(s.mergeAlternately("apbqcd", ""))  # Expected: "apbqcd"