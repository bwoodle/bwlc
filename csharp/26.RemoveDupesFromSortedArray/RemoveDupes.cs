internal class RemoveDupes
{
    public void Test()
    {
        var nums = new int[] {1,1,2};
        var rval = RemoveDuplicates(nums);
        Console.WriteLine($"Expect 2 // Value: {rval}");
        Console.WriteLine($"Expect 1,2 // Value: {nums.PrintArr()}");
        
        nums = new int[] {0,0,1,1,1,2,2,3,3,4};
        rval = RemoveDuplicates(nums);
        Console.WriteLine($"Expect 5 // Value: {rval}");
        Console.WriteLine($"Expect 0,1,2,3,4 // Value: {nums.PrintArr()}");
    }

    public int RemoveDuplicates(int[] nums) {
        var lastValSeen = -101;
        var printPtr = 0;
        for(int idx = 0; idx < nums.Length; idx++)
        {
            if(nums[idx] != lastValSeen)
            {
                lastValSeen = nums[idx];
                nums[printPtr++] = nums[idx];
            }
        }
        return printPtr;
    }
}