using System;
class StringsAndObjects
{
    static void Main(string[] args)
    {
        string strHello = "Hello";
        string strWorld = "World";

        object concatenateStr = strHello + " " + strWorld;
        string castStr = (string)concatenateStr;

        Console.WriteLine(concatenateStr);
        Console.WriteLine(castStr);
    }
}
