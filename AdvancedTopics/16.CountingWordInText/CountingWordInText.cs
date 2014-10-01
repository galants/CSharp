using System;
using System.IO;
using System.Linq;

internal class CountingWordInText
{
    private static void Main(string[] args)
    {
        Console.SetIn(new StreamReader(Console.OpenStandardInput(450)));

        string findStr = Console.ReadLine().ToLower();
        string str = Console.ReadLine().ToLower();
        string[] strArr = str.Split(new string[] {" ", ".", ",", "(", ")", "\"", "/", "!", "@"},
            StringSplitOptions.RemoveEmptyEntries);

        int result = strArr.Where(element => element.Equals(findStr)).Count();

        Console.WriteLine(result);
    }
}