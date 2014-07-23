using System;
class Sunglasses
{
    static void Main(string[] args)
    {
        byte n = byte.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n * 2; j++)
            {
                if((0 == i || (n-1)==i)||(0==j||(n*2-1)==j))
                    Console.Write("*");
                else
                    Console.Write("/");
            }

            for (int m = 0; m < n; m++)
            {
                if (i == n / 2)
                    Console.Write("|");
                else
                    Console.Write(" ");
            } 
            
            for (int l = 0; l < n * 2; l++)
            {
                if ((0 == i || (n - 1) == i) || (0 == l || (n * 2 - 1) == l))
                    Console.Write("*");
                else
                    Console.Write("/");
            }
                Console.WriteLine();
        }
    }
}
