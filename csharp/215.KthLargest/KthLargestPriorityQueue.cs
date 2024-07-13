internal class KthLargestPriorityQueue
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
        var priorityQueue = new PriorityQueue<int, int>(k+1, Comparer<int>.Create((a,b) => a - b));
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (priorityQueue.Count == k)
            {
                priorityQueue.EnqueueDequeue(nums[i], nums[i]);
            }
            else
            {
                priorityQueue.Enqueue(nums[i], nums[i]);
            }
        }

        return priorityQueue.Dequeue();
    }
}