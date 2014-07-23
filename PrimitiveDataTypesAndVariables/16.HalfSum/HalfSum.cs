using System;
class HalfSum
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[][] numbers = new int[2][];
        numbers[0] = new int[n];
        numbers[1] = new int[n];
        int sum1 = 0;
        int sum2 = 0;

        for (int i = 0; i < n; i++)
        {
            numbers[0][i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            numbers[1][i] = int.Parse(Console.ReadLine());
        }

        foreach (int num in numbers[0])
        {
            sum1 += num;
        }
        foreach (int num in numbers[1])
        {
            sum2 += num;
        }

        if(sum1==sum2)
            Console.WriteLine("Yes, sum={0}", sum1);
        else
            Console.WriteLine("No, diff={0}",Math.Abs(sum1-sum2));

    }
}
