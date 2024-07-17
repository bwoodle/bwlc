internal class MinStackTester
{
    public void Test()
    {
        MinStack obj = new MinStack();
        obj.Push(-2);
        obj.Push(0);
        obj.Push(-3);
        Console.WriteLine($"Expect {obj.GetMin()} to be -3");
        obj.Pop();
        obj.Top();
        Console.WriteLine($"Expect {obj.GetMin()} to be -2");
    }
}