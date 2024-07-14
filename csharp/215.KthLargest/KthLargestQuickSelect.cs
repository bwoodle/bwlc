using System.Globalization;

internal class KthLargestQuickSelect
{
    public void Test()
    {
        Console.WriteLine($"Expect {FindKthLargest([3,2,1,5,6,4], 2)} to be 5");
        Console.WriteLine($"Expect {FindKthLargest([3,2,3,1,2,4,5,5,6], 4)} to be 4");
    }
/*
Given an integer array nums and an integer k, return the kth largest element in the array.

Note that it is the kth largest element in the sorted order, not the kth distinct element.

Can you solve it without sorting?

1 <= k <= nums.length <= 105
-104 <= nums[i] <= 104
*/
    private int FindKthLargest(int[] nums, int k) 
    {
        var random = new Random();
        return nums[partition(nums, 0, nums.Length - 1, nums.Length - k, random)];
    }

    private int partition(int[] nums, int start, int end, int targetIdx, Random random)
    {
        if (end - start == 0)
        {
            return start;
        }
        else if (end - start == 1)
        {
            if (nums[end] < nums[start])
            {
                var swap = nums[end];
                nums[end] = nums[start];
                nums[start] = swap;
            }
            return targetIdx;
        }

        var rnd = random.Next(start, end);
        var pivotSwap = nums[rnd];
        nums[rnd] = nums[end];
        nums[end] = pivotSwap;

        var pivotVal = nums[end];
        var pivot = start;
        for (int i = start; i < end; i++)
        {
            if (nums[i] < pivotVal)
            {
                if (i == pivot)
                {
                    pivot++;
                }
                else 
                {
                    var swap = nums[pivot];
                    nums[pivot] = nums[i];
                    nums[i] = swap;
                    pivot++;
                }
            }
        }
        var swap2 = nums[pivot];
        nums[pivot] = nums[end];
        nums[end] = swap2;

        if (targetIdx == pivot)
        {
            return pivot;
        }
        else if (targetIdx > pivot)
        {
            return partition(nums, pivot + 1, end, targetIdx, random);
        }
        else
        {
            return partition(nums, start, pivot - 1, targetIdx, random);
        }
    }
}