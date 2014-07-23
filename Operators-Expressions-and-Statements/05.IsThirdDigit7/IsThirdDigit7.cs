using System;
class IsThirdDigit7
{
    static void Main(string[] args)
    {
        int num;
        bool expression;

        num = int.Parse(Console.ReadLine());
        expression = (7 == (num / 100) % 10);

        Console.WriteLine(expression);
    }
}
