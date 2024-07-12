internal class KthLargestSolution
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
        var valueChanged = SwapKth(nums, nums.Length - k);
        while (valueChanged)
        {
            valueChanged = SwapKth(nums, nums.Length - k);
        }
        return nums[nums.Length - k];
    }

    private bool SwapKth(int[] nums, int kthLargestIdx)
    {
        bool rval = false;
        for(int i = 0; i < kthLargestIdx; i++)
        {
            if(nums[i] > nums[kthLargestIdx])
            {
                var swap = nums[kthLargestIdx];
                nums[kthLargestIdx] = nums[i];
                nums[i] = swap;
                rval = true;
            }
        }
        for(int i = kthLargestIdx + 1; i < nums.Length; i++)
        {
            if(nums[i] < nums[kthLargestIdx])
            {
                var swap = nums[kthLargestIdx];
                nums[kthLargestIdx] = nums[i];
                nums[i] = swap;
                rval = true;
            }
        }
        return rval;
    }
}