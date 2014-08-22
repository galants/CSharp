using System;
class Arrow
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int doubleN = 2 * n;
        string dot = ".";
        string dies = "#";

        for (int j = 0; j < n / 2; j++)
            Console.Write(dot);

        for (int j = 0; j < n; j++)
            Console.Write(dies);

        for (int j = 0; j < n / 2; j++)
            Console.Write(dot);

        Console.WriteLine();

        for (int i = 1; i < (n - 1); i++)
        {
            for (int j = 0; j < n / 2; j++)
                Console.Write(dot);

            Console.Write(dies);

            for (int j = 0; j < (n - 2); j++)
                Console.Write(dot);

            Console.Write(dies);

            for (int j = 0; j < n / 2; j++)
                Console.Write(dot);

            Console.WriteLine();
        }

        for (int j = 0; j < (n + 1) / 2; j++)
            Console.Write(dies);

        for (int j = 0; j < (n - 2); j++)
            Console.Write(dot);

        for (int j = 0; j < (n + 1) / 2; j++)
            Console.Write(dies);

        Console.WriteLine();

        for (int i = 1; i < n - 1; i++)
        {
            for (int j = 0; j < i; j++)
                Console.Write(dot);

            Console.Write(dies);

            for (int j = 0; j < (2 * n - 2 * i - 3); j++)
                Console.Write(dot);

            Console.Write(dies);

            for (int j = 0; j < i; j++)
                Console.Write(dot);

            Console.WriteLine();
        }

        for (int j = 0; j < (n - 1); j++)
            Console.Write(dot);

        Console.Write(dies);

        for (int j = 0; j < (n - 1); j++)
            Console.Write(dot);

        Console.WriteLine();
    }
}