using System;
class TheExplorer
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < Math.Abs((n / 2) - i); j++)
            {
                Console.Write('-');
            }

            Console.Write('*');

            if (0 != i && (n - 1) != i)
            {
                for (int j = 0; j < n-2-(Math.Abs((n / 2) - i))*2; j++)
                {
                    Console.Write('-');
                }
                Console.Write('*');
            }

            for (int j = 0; j < Math.Abs((n / 2) - i); j++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }
    }
}
