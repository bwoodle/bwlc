internal class LongestContIncreSubseq
{
    
    public void Test()
    {
        Console.WriteLine($"Expect {FindLengthOfLCIS([1,3,5,4,7])} to be 3");
        Console.WriteLine($"Expect {FindLengthOfLCIS([1,3,5,4,7,7])} to be 3");
        Console.WriteLine($"Expect {FindLengthOfLCIS([1,3,5,4,7,6])} to be 3");
        Console.WriteLine($"Expect {FindLengthOfLCIS([2,2,2,2,2])} to be 1");
    }
/*
Given an unsorted array of integers nums, return the length of the longest continuous increasing subsequence (i.e. subarray). The subsequence must be strictly increasing.

A continuous increasing subsequence is defined by two indices l and r (l < r) such that it is [nums[l], nums[l + 1], ..., nums[r - 1], nums[r]] and for each l <= i < r, nums[i] < nums[i + 1].

1 <= nums.length <= 10^4
-10^9 <= nums[i] <= 10^9
*/
    public int FindLengthOfLCIS(int[] nums) {
        int currLen = 1, maxLen = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i-1])
            {
                currLen++;
                continue;
            }
            if (currLen > maxLen)
            {
                maxLen = currLen;
            }
            if (nums.Length - i < maxLen)
            {
                return maxLen;
            }
            currLen = 1;
        }
        return currLen > maxLen ? currLen : maxLen;
    }
}