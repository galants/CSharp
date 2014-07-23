using System;
class PrintsCurrentDateAndTime
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;

        Console.WriteLine(now);
    }
}