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

        var flush = true;
        for (int i = 1; i < 5; i++)
        {
            if (suits[i] != suits[0])
            {
                flush = false;
                break;
            }
        }
        if (flush)
        {
            return "Flush";
        }

        var hash = new HashSet<int>();
        var hash2 = new HashSet<int>();
        for (int i = 0; i < 5; i++)
        {
            if (hash.Contains(ranks[i]))
            {
                if (hash2.Contains(ranks[i]))
                {
                    return "Three of a Kind";
                }
                else
                {
                    hash2.Add(ranks[i]);
                }
            }
            else
            {
                hash.Add(ranks[i]);
            }
        }
        return hash2.Any() ? "Pair" : "High Card";
    }
}