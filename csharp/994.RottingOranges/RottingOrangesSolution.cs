internal class RottingOranges
{
    public void Test()
    {
        Console.WriteLine($"Expect {OrangesRotting(new int[][] {new int[] {1,2}})} to be 1");
        Console.WriteLine($"Expect {OrangesRotting(new int[][] {new int[] {2,1,1}, new int[] {1,1,0}, new int[] {0,1,1}})} to be 4");
        Console.WriteLine($"Expect {OrangesRotting(new int[][] {new int[] {2,1,1}, new int[] {0,1,1}, new int[] {1,0,1}})} to be -1");
        Console.WriteLine($"Expect {OrangesRotting(new int[][] {new int[] {0,2}})} to be 0");
    }

/*
You are given an m x n grid where each cell can have one of three values:

0 representing an empty cell,
1 representing a fresh orange, or
2 representing a rotten orange.
Every minute, any fresh orange that is 4-directionally adjacent to a rotten orange becomes rotten.

Return the minimum number of minutes that must elapse until no cell has a fresh orange. If this is impossible, return -1.

m == grid.length
n == grid[i].length
1 <= m, n <= 10
grid[i][j] is 0, 1, or 2.
*/
        
    private int OrangesRotting(int[][] grid) {
        var seconds = -1;
        var previousRotCount = -1;
        var rotCount = RotCount(grid);
        while(rotCount != previousRotCount)
        {
            seconds++;
            previousRotCount = rotCount;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        // left
                        if (i > 0 && grid[i-1][j] == 1)
                        {
                            grid[i-1][j] = 3;
                        }
                        // right
                        if (i < grid.Length - 1 && grid[i+1][j] == 1)
                        {
                            grid[i+1][j] = 3;
                        }
                        // up
                        if (j > 0 && grid[i][j-1] == 1)
                        {
                            grid[i][j-1] = 3;
                        }
                        // down
                        if (j < grid[i].Length - 1 && grid[i][j+1] == 1)
                        {
                            grid[i][j+1] = 3;
                        }
                    }
                }
            }

            rotCount = RotCount(grid);
        }
        return FreshRemain(grid) ? -1 : seconds;
    }

    private int RotCount(int[][] grid)
    {
        var rot = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 3)
                {
                    grid[i][j] = 2;
                    rot++;
                }
                else if (grid[i][j] == 2)
                {
                    rot++;
                }
            }
        }
        return rot;
    }

    private bool FreshRemain(int[][] grid)
    {
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    return true;
                }
            }
        }
        return false;
    }
}