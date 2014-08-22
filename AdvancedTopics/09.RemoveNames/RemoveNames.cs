using System;
using System.Collections.Generic;
using System.Linq;
class RemoveNames
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] firstList = str.Split(new char[] { ' ' });

        str = Console.ReadLine();
        string[] secondList = str.Split(new char[] { ' ' });

        var strExcept = from element in firstList
                        where !secondList.Contains<string>(element)
                         select element;

        foreach(string print in strExcept)
            Console.Write(print+" ");
    }
}
