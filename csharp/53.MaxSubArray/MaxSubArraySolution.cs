internal class MaxSubArraySolution
{
    public void Test()
    {
        // var res = MaxSubArray(new int[] {-2,1,-3,4,-1,2,1,-5,4});
        // Console.WriteLine($"Expect 6, Actual {res}");

        var res = MaxSubArray(new int[] {1});
        Console.WriteLine($"Expect 1, Actual {res}");

        res = MaxSubArray(new int[] {5,4,-1,7,8});
        Console.WriteLine($"Expect 23, Actual {res}");
    }
    /*
        Given an integer array nums, find the subarray with the largest sum, and return its sum.
        1 <= nums.length <= 10^5
        -10^4 <= nums[i] <= 10^4

        Livestreaming thoughts:
        - 10^9 max value fits within max int
        - One option is to find the max value of each length of subarray from 1 to n
        - If I want to find a more efficient algorithm, how would I deal with idx 0 = 10^4, idx n-1 = 10^4, and every other idx = -1?
    */
    
    public int MaxSubArray(int[] nums) {
        int maxVal = nums[0];
        return CalcSubArray(nums, 0, nums.Length - 1);
    }

    private int CalcSubArray(int[] nums, int startIdx, int endIdx)
    {
        if (startIdx == endIdx)
        {
            return nums[startIdx];
        }
        var split = (endIdx - startIdx) / 2 + startIdx;
        var left = CalcSubArray(nums, startIdx, split);
        var right = CalcSubArray(nums, split + 1, endIdx);
        var crossingMax = CalcMaxCrossing(nums, startIdx, split, endIdx);

        return Math.Max(Math.Max(left, right), crossingMax);

    }

    private int CalcMaxCrossing(int[] nums, int startIdx, int split, int endIdx)
    {
        throw new NotImplementedException();
    }

    // Working Solution, but takes too long
    public int MaxSubArrayOne(int[] nums) {
        var maxSum = nums[0];
        // i is the length of the subarray
        // j is the starting index of the subarray
        for(int i = 1; i <= nums.Length; i++)
        {
            var j = 0;
            var curVal = nums[j];
            while(++j < i)
            {
                curVal += nums[j];
            }
            while(j < nums.Length)
            {
                if (curVal > maxSum)
                {
                    maxSum = curVal;
                }
                curVal -= nums[j-i];
                curVal += nums[j++];
            }
            if (curVal > maxSum)
            {
                maxSum = curVal;
            }
        }
        return maxSum;
    }
}