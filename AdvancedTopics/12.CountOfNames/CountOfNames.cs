using System;
using System.Linq;

internal class CountOfNames
{
    private static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] strArr = str.Split(new char[] {' '});

        var result = from i in strArr
            orderby i
            group i by i
            into g
            select new {Group = g.Key, ItemCount = g.Count()};

        foreach (var element in result)
            Console.WriteLine("{0} -> {1}", element.Group, element.ItemCount);
    }
}