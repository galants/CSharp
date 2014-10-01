using System;
class TheBiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        double[] numbers = new double[5];

        for (int i = 0; i < numbers.Length; i++)
            numbers[i] = double.Parse(Console.ReadLine());

        Array.Sort<double>(numbers);
        Console.WriteLine(numbers[numbers.Length-1]);
    }
}
