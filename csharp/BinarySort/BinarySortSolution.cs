public class BinarySortSolution
{
    public void Test()
    {
        BinarySort(new int[] {1, 5, 2, 3, 6, 2, 1, 9, 9, 2}).PrintArray(); // 1 1 2 2 2 3 5 6 9 9
        BinarySort(new int[] {1}).PrintArray(); // 1
        BinarySort(new int[] {2, 1}).PrintArray(); // 1 2
        BinarySort(new int[] {2, 3, 1}).PrintArray(); // 1 2 3
        BinarySort(new int[] {4, 3, 2, 1}).PrintArray(); // 1 2 3 4
    }

    private int[] BinarySort(int[] arr)
    {
        Sort(arr, 0, arr.Length);
        return arr;
    }

    // Haven't thought about this problem in depth for 16 years, but let me walk through it
    // I'm most worried about getting off-by-one errors or index out of bounds reading past the end of the array
    // For an array with 4 elements, we want to start with indices (0, 3), then have inner calls for (0, 1) and (2, 3)
    // For an array with 5 elements, (0, 4), (0, 2) 
    private void Sort(int[] arr, int beginIndex, int endIndex)
    {
        if (endIndex - beginIndex <= 1)
        {
            return;
        }
        var split = beginIndex + (endIndex - beginIndex) / 2;
        Sort(arr, beginIndex, split);
        Sort(arr, split + 1, endIndex);
        int a = beginIndex, b = split;
        while (a < split && b < endIndex)
        {
            if (b < a)
            {
                Swap(arr, a, b);
            }
            a++;
            b++;
        }
    }

    private void Swap(int[] arr, int idx1, int idx2)
    {
        var save = arr[idx1];
        arr[idx1] = arr[idx2];
        arr[idx2] = save;
    }
}