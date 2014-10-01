using System;

internal class SortingNumbers
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        foreach (int num in numbers)
            Console.WriteLine(num);
    }
}