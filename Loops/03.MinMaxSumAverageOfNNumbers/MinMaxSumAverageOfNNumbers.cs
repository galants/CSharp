using System;
public class MinMaxSumAverageOfNNumbers
{
    static int num = 0;
    static int min = int.MaxValue;
    static int max = 0;
    static int sum = 0;
    static double avg = 0;

    static void Main(string[] args)
    {
        MinMaxSumAverageOfNNumbers obj = new MinMaxSumAverageOfNNumbers();
        num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            int number = int.Parse(Console.ReadLine());

            obj.Sum(number);
            obj.Max(number);
            obj.Min(number);
        }

        obj.Avg();

        obj.Print();
    }

    public void Sum(int number)
    {
        sum += number;
    }

    public void Max(int number)
    {
        if (max < number)
            max = number;
    }

    public void Min(int number)
    {
        if (min > number)
            min = number;
    }

    public void Avg()
    {
        avg = (double)sum / num;
    }

    public void Print()
    {
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F}", avg);
    }
}

