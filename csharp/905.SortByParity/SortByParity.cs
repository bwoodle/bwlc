using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class SortByParity
{
    public void Test()
    {
        PrintResult(SortArrayByParity(new int[] { 3, 1, 2, 4 }));
        PrintResult(SortArrayByParity(new int[] { 0 }));
        PrintResult(SortArrayByParity(new int[] { 0, 0 }));
        PrintResult(SortArrayByParity(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 }));
    }

    private void PrintResult(int[] result)
    {
        var str = "[";
        result.ToList().ForEach(n => str += $"{n}, ");
        str = str.Substring(0, str.Length - 2) + "]";
        Console.WriteLine(str);
    }

    public int[] SortArrayByParity(int[] nums)
    {
        var idx1 = 0;
        var idx2 = nums.Length - 1;
        while (idx1 <= idx2)
        {
            if (nums[idx1] % 2 == 0)
            {
                idx1++;
            }
            if (nums[idx2] % 2 == 1)
            {
                idx2--;
            }
            if (idx1 < idx2 && nums[idx1] % 2 == 1 && nums[idx2] % 2 == 0)
            {
                Swap(nums, idx1++, idx2--);
            }
        }
        return nums;
    }

    private void Swap(int[] nums, int idx1, int idx2)
    {
        int save = nums[idx1];
        nums[idx1] = nums[idx2];
        nums[idx2] = save;
    }
}
