using System;
class SumOfNNumbers
{
    static void Main(string[] args)
    {
        int n;
        double sum = 0;

        n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
            sum += double.Parse(Console.ReadLine());

        Console.WriteLine(sum);
    }
}
