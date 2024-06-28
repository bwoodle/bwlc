using System.Globalization;

internal class MergeSortedArray
{
    public void Test()
    {
        int[] nums1 = [1,2,3,0,0,0];
        int[] nums2 = [2,5,6];
        Merge(nums1, 3, nums2, 3);
        PrintResult(nums1);
        Console.WriteLine("Expect 122356");
        
        nums1 = [1];
        nums2 = [];
        Merge(nums1, 1, nums2, 0);
        PrintResult(nums1);
        Console.WriteLine("Expect 1");

        
        nums1 = [0];
        nums2 = [1];
        Merge(nums1, 0, nums2, 1);
        PrintResult(nums1);
        Console.WriteLine("Expect 1");
        
        nums1 = [4,5,6,0,0,0];
        nums2 = [1,2,3];
        Merge(nums1, 3, nums2, 3);
        PrintResult(nums1);
        Console.WriteLine("Expect 123456");
    }

    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i = m - 1, j = n - 1;
        int ptr = m + n - 1;
        while (ptr >= 0)
        {
            if (i < 0)
            {
                nums1[ptr--] = nums2[j--];
            }
            else if (j < 0 || nums1[i] >= nums2[j])
            {
                nums1[ptr--] = nums1[i--];
            }
            else if (nums1[i] < nums2[j])
            {
                nums1[ptr--] = nums2[j--];
            }
        }
    }

    private void PrintResult(int[] result)
    {
        var str = "[";
        result.ToList().ForEach(n => str += $"{n}, ");
        str = str.Substring(0, str.Length - 2) + "]";
        Console.WriteLine(str);
    }
}