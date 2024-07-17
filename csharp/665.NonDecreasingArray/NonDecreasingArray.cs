internal class NonDecreasingArray
{
    public void Test()
    {
        Console.WriteLine($"Expect {CheckPossibility([4,2,3])} to be true");
        Console.WriteLine($"Expect {CheckPossibility([4,2,1])} to be false");
        Console.WriteLine($"Expect {CheckPossibility([1,1,2,1,1,1,1,1])} to be true");
        Console.WriteLine($"Expect {CheckPossibility([1,1,0,1,1,1,1,1])} to be true");
        Console.WriteLine($"Expect {CheckPossibility([1,1,0,1,1,1,1,0])} to be false");
        Console.WriteLine($"Expect {CheckPossibility([3,4,2,3])} to be false");
        Console.WriteLine($"Expect {CheckPossibility([-1,4,2,3])} to be true");
    }
/*
Given an array nums with n integers, your task is to check if it could become non-decreasing by modifying at most one element.

We define an array is non-decreasing if nums[i] <= nums[i + 1] holds for every i (0-based) such that (0 <= i <= n - 2).

n == nums.length
1 <= n <= 104
-105 <= nums[i] <= 105
*/
    public bool CheckPossibility(int[] nums) {
        var replacementUsed = false;
        for(int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] > nums[i+1])
            {
                if (replacementUsed)
                {
                    return false;
                }

                // First choice is to decrease the nums[i]
                if (i >= 1 && nums[i-1] <= nums[i+1])
                {
                    replacementUsed = true;
                    nums[i] = nums[i-1];
                }
                else if (i == 0)
                {
                    replacementUsed = true;
                    nums[i] = int.MinValue;
                }
                else
                {
                    replacementUsed = true;
                    nums[i+1] = nums[i];
                }
            }
        }
        return true;
    }
}