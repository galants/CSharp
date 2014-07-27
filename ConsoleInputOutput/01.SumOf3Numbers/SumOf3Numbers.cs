using System;
class SumOf3Numbers
{
    static void Main(string[] args)
    {
        double a, b, c, sum;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        sum = a + b + c;

        Console.WriteLine(sum);
    }
}
