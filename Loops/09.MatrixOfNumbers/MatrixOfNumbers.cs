using System;
class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write(j+i-1);

                if(j!=n)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}