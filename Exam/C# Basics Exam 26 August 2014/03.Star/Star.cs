using System;
class Star
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 2 * n + 1;
        int height = n * 2 - (n / 2) - 1;

        for (int i = 0; i < n / 2; i++)
        {
            for (int j = i; j < width / 2; j++)
            {
                Console.Write(".");
            }

            Console.Write("*");

            for (int j = 0; j < 2 * i - 1; j++)
            {
                Console.Write(".");
            }

            if (i > 0)
            {
                Console.Write("*");
            }

            for (int j = i; j < width / 2; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < (n / 2 + 1); i++)
        {
            Console.Write("*");
        }
        for (int i = 0; i < (n - 1); i++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < (n / 2 + 1); i++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
        for (int i = 0; i < n / 2 - 1; i++)
        {
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int j = 0; j < width - 2 * (i + 2); j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int j = 0; j < i + 1; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n / 2; i++)
        {
            for (int j = 0; j < n / 2 - i; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");
            for (int j = 0; j < n / 2 - 1; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");

            for (int j = 0; j < 2 * i - 1; j++)
            {
                Console.Write(".");
            }

            if (i > 0)
            {
                Console.Write("*");
            }

            for (int j = 0; j < n / 2 - 1; j++)
            {
                Console.Write(".");
            }
            Console.Write("*");

            for (int j = 0; j < n / 2 - i; j++)
            {
                Console.Write(".");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < (n / 2 + 1); i++)
        {
            Console.Write("*");
        }
        for (int i = 0; i < (n - 1); i++)
        {
            Console.Write(".");
        }
        for (int i = 0; i < (n / 2 + 1); i++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}