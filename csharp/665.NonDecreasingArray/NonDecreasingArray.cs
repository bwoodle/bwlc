internal class NonDecreasingArray
{
    public void Test()
    {
        Console.WriteLine($"Expect {CheckPossibility([4,2,3])} to be true");
        Console.WriteLine($"Expect {CheckPossibility([4,2,1])} to be false");
    }
/*
Given an array nums with n integers, your task is to check if it could become non-decreasing by modifying at most one element.

We define an array is non-decreasing if nums[i] <= nums[i + 1] holds for every i (0-based) such that (0 <= i <= n - 2).

n == nums.length
1 <= n <= 104
-105 <= nums[i] <= 105
*/
    public bool CheckPossibility(int[] nums) {
        return false;
    }
}