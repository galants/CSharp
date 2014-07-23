using System;
class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        PrintVariableValues(a, b);

        a = a + b;
        b = a - b;
        a = a - b;

        PrintVariableValues(a, b);
    }
    static void PrintVariableValues(int a, int b)
    {
        Console.WriteLine("a = {0}\tb = {1}", a, b);
    }
}
