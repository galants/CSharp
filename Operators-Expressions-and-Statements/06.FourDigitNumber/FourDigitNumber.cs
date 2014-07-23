using System;
class FourDigitNumber
{
    static void Main(string[] args)
    {
        int num;
        int first;
        int second;
        int third;
        int fourth;
        int sum;

        num = int.Parse(Console.ReadLine());

        first = num / 1000;
        second = (num / 100) % 10;
        third = (num / 10) % 10;
        fourth = num % 10;

        sum = first + second + third + fourth;

        Console.WriteLine(sum);
        Console.WriteLine("" + fourth + third + second + first);
        Console.WriteLine("" + fourth + first + second + third);
        Console.WriteLine("" + first + third + second + fourth);
    }
}
