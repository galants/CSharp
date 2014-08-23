using System;
using System.Linq;
class ExtractURLsFromText
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] strArr = str.Split(new string[]{" ",". "}, StringSplitOptions.RemoveEmptyEntries);

        var result = strArr.Where(element => element.Contains("http://") || element.Contains("www."));

        foreach (var element in result)
            Console.WriteLine(element);
    }
}
