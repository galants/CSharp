using System;
using System.Linq;

internal class RemoveNames
{
    private static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] firstList = str.Split(new char[] {' '});

        str = Console.ReadLine();
        string[] secondList = str.Split(new char[] {' '});

        var strExcept = firstList.Where(element => !secondList.Contains<string>(element));

        foreach (string print in strExcept)
            Console.Write(print + " ");
    }
}