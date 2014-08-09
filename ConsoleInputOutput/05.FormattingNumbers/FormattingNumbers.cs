using System;
class FormattingNumbers
{
    static void Main(string[] args)
    {
        int a;
        double b;
        double c;

        a = int.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        Console.Write("|{0,-10:X}|", a);
        Console.Write("{0,10}|", Convert.ToString(a, 2).PadLeft(10, '0') );
        Console.Write("{0,10}|", Math.Round(b,2));
        Console.WriteLine("{0,-10}|", Math.Round(c,3));
    }
}