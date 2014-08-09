using System;
class NewHouse
{
    static void Main(string[] args)
    {
        int n;

        n = int.Parse(Console.ReadLine());

        for (int i = 0; i <= n/2; i++)
        {
            for (int j = 0; j < ((n / 2) - i); j++)
            {
                Console.Write('-');
            }
            for (int j = 0; j < (2 * i + 1); j++)
            {
                Console.Write('*');
            }
            for (int j = 0; j < ((n / 2) - i); j++)
            {
                Console.Write('-');
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write('|');
            for (int j = 0; j < (n - 2); j++)
            {
                Console.Write('*');
            }
            Console.Write('|');
            Console.WriteLine();
        }
    }
}