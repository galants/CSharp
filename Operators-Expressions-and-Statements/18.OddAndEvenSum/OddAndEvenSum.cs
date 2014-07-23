using System;
class OddAndEvenSum
{
    static void Main(string[] args)
    {
        int oddSum=0;
        int evenSum=0;
        int num;
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 2 * n; i++)
        {
            num = int.Parse(Console.ReadLine());

            if (0 == i % 2)
                evenSum += num;
            else
                oddSum += num;
        }

        if(evenSum == oddSum)
            Console.WriteLine("Yes, sum={0}",oddSum);
        else
            Console.WriteLine("No, diff={0}", Math.Abs(evenSum - oddSum));
    }
}
