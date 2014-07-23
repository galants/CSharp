using System;
class OddOrEvenIntegers
{
    static void Main(string[] args)
    {
        int value = int.Parse(Console.ReadLine());
        bool isOdd = !(0 == value % 2);

        Console.WriteLine(isOdd);
    }
}
