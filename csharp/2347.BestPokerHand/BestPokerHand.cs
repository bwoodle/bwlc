internal class BestPokerHand
{
    public void Test()
    {
        Console.WriteLine($"Expect: Flush, Actual: {BestHand(new int[] {13,2,3,1,9}, new char[] {'a','a','a','a','a'})}");
        Console.WriteLine($"Expect: Three of a Kind, Actual: {BestHand(new int[] {4,4,2,4,4}, new char[] {'d','a','a','b','c'})}");
        Console.WriteLine($"Expect: Pair, Actual: {BestHand(new int[] {10,10,2,12,9}, new char[] {'a','b','c','a','d'})}");
    }

    public string BestHand(int[] ranks, char[] suits)
    {
        // Assume 5 cards dealt
        // 1 <= ranks[i] <= 13
        // 'a' <= suits[i] <= 'd'
        // "Flush"
        // "Three of a Kind"
        // "Pair"
        // "High Card"

        return "";
    }
}