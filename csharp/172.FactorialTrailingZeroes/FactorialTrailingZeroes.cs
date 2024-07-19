internal class FactorialTrailingZeroes
{
    public void Test()
    {
        Console.WriteLine($"Expect {TrailingZeroes(3)} to be 0");
        Console.WriteLine($"Expect {TrailingZeroes(5)} to be 1");
        Console.WriteLine($"Expect {TrailingZeroes(0)} to be 0");
        Console.WriteLine($"Expect {TrailingZeroes(9)} to be 1");
        Console.WriteLine($"Expect {TrailingZeroes(10)} to be 2");
        Console.WriteLine($"Expect {TrailingZeroes(14)} to be 2");
        Console.WriteLine($"Expect {TrailingZeroes(15)} to be 3");
        Console.WriteLine($"Expect {TrailingZeroes(50)} to be 12");
        Console.WriteLine($"Expect {TrailingZeroes(625)} to be 156");
    }
/*
Given an integer n, return the number of trailing zeroes in n!.
Note that n! = n * (n - 1) * (n - 2) * ... * 3 * 2 * 1.

0 <= n <= 10^4
Follow up: Could you write a solution that works in logarithmic time complexity?
*/

    public int TrailingZeroes(int n) {
        // Cheated to get this solution - I get it, but this problem is tough if you don't know the trick
        var zeros = 0;
        while (n >= 5)
        {
            n /= 5;
            zeros+= n;
        }
        return zeros;
    }

    public int TrailingZeroesOld(int n) {
        // Working but inefficient solution
        long lastTrailingDigit = 1;
        var zeroCount = 0;
        for (int i = 2; i <= n; i++)
        {
            lastTrailingDigit = lastTrailingDigit * i;
            Console.WriteLine($"lastTrailingDigit is {lastTrailingDigit} with i={i}");
            while (lastTrailingDigit % 10 == 0)
            {
                lastTrailingDigit = lastTrailingDigit / 10;
                zeroCount++;
                Console.WriteLine($"lastTrailingDigit is {lastTrailingDigit} zeroCount++={zeroCount} with i={i}");
            }
            lastTrailingDigit = lastTrailingDigit % 1000000000;
        }
        return zeroCount;
    }

/*
1 = 1
2 = 2
3 = 6
4 = 24
5 = 120
6 = 720
7 = 5040
8 = 40320
9 = 362880
10 = 3628800
n! = n*(n -1)!
*/
}