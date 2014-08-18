using System;
class SpiralMatrix
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[,] numbers = new int[n, n];
        int maxNum = n * n;
        int number = 1;
        int startRow = 0;
        int startCol = 0;
        int endRow = n - 1;
        int endCol = n - 1;
        int row = 0;
        int col = 0;

        do
        {
            if (row == startRow && col == startCol)
            {
                for (int i = startCol; i <= endCol; i++)
                    numbers[row, i] = number++;
                col = endCol;
                row = ++startRow;
            }
            else if (row == startRow && col == endCol)
            {
                for (int i = startRow; i <= endRow; i++)
                    numbers[i, col] = number++;
                row = endRow;
                col=--endCol;
            }
            else if (row == endRow && col == endCol)
            {
                for (int i = endCol; i >= startCol; i--)
                    numbers[row, i] = number++;
                col = startCol;
                row=--endRow;
            }
            else if (row == endRow && col == startCol)
            {
                for (int i = endRow; i >= startRow; i--)
                    numbers[i, col] = number++;
                row = startRow;
                col=++startCol;
            }
        } while (number <= maxNum);

        //for (int i = 0; i < 2*n-2 ; i++)
        //{
        //    for (int j = 0; j < n; j++)
        //    {
        //        numbers[i, j] = number++;
        //    }

        //}

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-3}", numbers[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
