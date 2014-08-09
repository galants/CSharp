using System;
class NumbersInIntervalDividableByGivenNumber
{
    static void Main(string[] args)
    {
        int start, end;
        int p=0;

        start = int.Parse(Console.ReadLine());
        end = int.Parse(Console.ReadLine());

        for (int i = start; i <= end; i++)
        {
            if (0 == i % 5)
                p++;
        }

        Console.WriteLine(p);
    }
}
