internal class RemoveDupesSortedTwo
{
    public void Test()
    {
        var nums = new int[] {1,1,1,2,2,3};
        var rval = RemoveDuplicates(nums);
        Console.WriteLine($"Expect 5 // Value: {rval}");
        Console.WriteLine($"Expect 1,1,2,2,3 // Value: {nums.PrintArr()}");
        
        nums = new int[] {0,0,1,1,1,1,2,3,3};
        rval = RemoveDuplicates(nums);
        Console.WriteLine($"Expect 7 // Value: {rval}");
        Console.WriteLine($"Expect 0,0,1,1,2,3,3 // Value: {nums.PrintArr()}");
    }

    public int RemoveDuplicates(int[] nums) {
        var lastValSeenCount = 0;
        var lastValSeen = -100000;
        var printPtr = 0;
        for(int idx = 0; idx < nums.Length; idx++)
        {
            if(nums[idx] == lastValSeen && lastValSeenCount < 2)
            {
                lastValSeenCount++;
                nums[printPtr++] = nums[idx];
            }
            else if(nums[idx] != lastValSeen)
            {
                lastValSeen = nums[idx];
                lastValSeenCount = 1;
                nums[printPtr++] = nums[idx];
            }
        }
        return printPtr;
    }
}