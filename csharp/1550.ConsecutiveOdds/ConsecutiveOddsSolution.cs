internal class ConsecutiveOddsSolution
{
    public void Test()
    {
        Console.WriteLine($"Expect {ThreeConsecutiveOdds(new int[] {2,6,4,1})} to be false");
        Console.WriteLine($"Expect {ThreeConsecutiveOdds(new int[] {1,2,34,3,4,5,7,23,12})} to be true");
    }

    private bool ThreeConsecutiveOdds(int[] arr)
    {
        short consecutiveOdds = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 1)
            {
                if (consecutiveOdds == 2)
                {
                    return true;
                }
                consecutiveOdds++;
            }
            else if (consecutiveOdds > 0)
            {
                consecutiveOdds = 0;
            }
        }
        return false;
    }
}