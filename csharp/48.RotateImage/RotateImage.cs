using System.Net.WebSockets;
using System.Security.Cryptography;

internal class RotateImage
{
/*
You are given an n x n 2D matrix representing an image, rotate the image by 90 degrees (clockwise).

You have to rotate the image in-place, which means you have to modify the input 2D matrix directly. DO NOT allocate another 2D matrix and do the rotation.

n == matrix.length == matrix[i].length
1 <= n <= 20
-1000 <= matrix[i][j] <= 1000
*/



    public void Test()
    {
        int[][] input1 = new int[][] {new int[] {1,2,3}, new int[] {4,5,6}, new int[] {7,8,9}};
        Rotate(input1);
        Console.WriteLine("Expect 7 4 1 // 8 5 2 // 9 6 3");
        for (int i = 0; i < input1.Length; i++)
        {
            Console.WriteLine(input1[i].PrintArr());
        }


        int[][] input2 = new int[][] {new int[] {5,1,9,11}, new int[] {2,4,8,10}, new int[] {13,3,6,7}, new int[] {15,14,12,16}};
        Rotate(input2);
        Console.WriteLine("Expect 15 13 2 5 // 14 3 4 1 // 12 6 8 9 // 16 7 10 11");
        for (int i = 0; i < input2.Length; i++)
        {
            Console.WriteLine(input2[i].PrintArr());
        }
    }

    private void Rotate(int[][] matrix)
    {
        Transpose(matrix);
        VerticallyMirror(matrix);
    }

    private void Transpose(int[][] matrix)
    {
        // row
        for (int i = 0; i < matrix.Length - 1; i++)
        {
            // column
            for (int j = i + 1; j < matrix[i].Length; j++)
            {
                var swap = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = swap;
            }
        }
    }

    private void VerticallyMirror(int[][] matrix)
    {
        // every row
        for(int i = 0; i < matrix.Length; i++)
        {
            // First half of columns
            for (int j = 0; j < matrix[i].Length / 2; j++)
            {
                var swap = matrix[i][j];
                matrix[i][j] = matrix[i][matrix[i].Length - j - 1];
                matrix[i][matrix[i].Length - j - 1] = swap;
            }
        }
    }
}