internal class KthLargestAdd
{
    public void Test()
    {
        var testable = new KthLargest(3, [4, 5, 8, 2]);
        Console.WriteLine($"Expect {testable.Add(3)} to be 4");
        Console.WriteLine($"Expect {testable.Add(5)} to be 5");
        Console.WriteLine($"Expect {testable.Add(10)} to be 5");
        Console.WriteLine($"Expect {testable.Add(9)} to be 8");
        Console.WriteLine($"Expect {testable.Add(4)} to be 8");
    }
}

internal class KthLargest
{
    private PriorityQueue<int,int> _minHeap;
    private int _k;
    public KthLargest(int k, int[] nums) {
        _k = k;
        _minHeap = new PriorityQueue<int, int>(k+1, Comparer<int>.Create((a,b) => a - b));
        foreach(var num in nums)
        {
            if (_minHeap.Count == _k)
            {
                _minHeap.EnqueueDequeue(num, num);
            }
            else
            {
                _minHeap.Enqueue(num, num);
            }
        }
    }
    
    public int Add(int val) {
        if (_minHeap.Count == _k)
        {
            _minHeap.EnqueueDequeue(val, val);
        }
        else
        {
            _minHeap.Enqueue(val, val);
        }
        return _minHeap.Peek();
    }
}