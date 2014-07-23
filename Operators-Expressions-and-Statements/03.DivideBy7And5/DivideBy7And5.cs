using System;
class DivideBy7And5
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        bool expression;

        expression = (0 < num) && (0 == num % 7) && (0 == num % 5);

        Console.WriteLine(expression);
    }
}
