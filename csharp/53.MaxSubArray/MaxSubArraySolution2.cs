internal class MaxSubArraySolution2
{
    public void Test()
    {
        // var res = MaxSubArray(new int[] {-2,1,-3,4,-1,2,1,-5,4});
        // Console.WriteLine($"Expect 6, Actual {res}");

        var res = MaxSubArray(new int[] {1});
        Console.WriteLine($"Expect 1, Actual {res}");

        res = MaxSubArray(new int[] {5,4,-1,7,8});
        Console.WriteLine($"Expect 23, Actual {res}");

        res = MaxSubArray(new int[] {-12,-1});
        Console.WriteLine($"Expect -1, Actual {res}");

        res = MaxSubArray(new int[] {-1,-12});
        Console.WriteLine($"Expect -1, Actual {res}");

        res = MaxSubArray(new int[] {-1,-12,0});
        Console.WriteLine($"Expect 0, Actual {res}");
    }
    /*
        Given an integer array nums, find the subarray with the largest sum, and return its sum.
        1 <= nums.length <= 10^5
        -10^4 <= nums[i] <= 10^4
    */
    
    public int MaxSubArray(int[] nums) {
        var maxSum = nums[0];
        var curSum = nums[0] > 0 ? nums[0] : 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] + curSum >= maxSum)
            {
                maxSum = nums[i] + curSum;
            }
            curSum = (nums[i] + curSum) > 0 ? (nums[i] + curSum) : 0;
        }

        return maxSum;
    }
}