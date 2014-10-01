using System;
using System.Linq;

internal class LongestWordInText
{
    private static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] strArr = str.Split(new char[] {' ', '.'});

        var result = strArr.Where(element => element.Length == strArr.Max(ele => ele.Length)).First();
        Console.WriteLine(result);
    }
}