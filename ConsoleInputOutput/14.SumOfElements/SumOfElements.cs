using System;
class SumOfElements
{
    static void Main(string[] args)
    {
        string str;
        int[] numbers;
        long sum = 0L;
        long max = long.MinValue;

        str = Console.ReadLine();
        numbers = Array.ConvertAll<string, int>(str.Split(' '), int.Parse);

        foreach (int num in numbers)
        {
            sum += num;
            max = Math.Max(max, num);
        }

        if (sum == 2 * max)
            Console.WriteLine("Yes, sum=" + max);
        else
            Console.WriteLine("No, diff=" + Math.Abs(sum - 2 * max));
    }
}