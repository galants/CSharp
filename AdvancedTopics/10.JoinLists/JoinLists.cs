using System;
using System.Linq;
class JoinLists
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string[] firstStrArr = str.Split(new char[] { ' ' });
        int[] firstIntArray = (Array.ConvertAll<string, int>(firstStrArr, int.Parse));

        str = Console.ReadLine();
        string[] secondStrArr = str.Split(new char[] { ' ' });
        int[] secondIntArray = (Array.ConvertAll<string, int>(secondStrArr, int.Parse));

        var result = firstIntArray.Union(secondIntArray).Distinct();

        var sortResult = from elements in result
                         orderby elements
                         select elements;

        foreach (int num in sortResult)
            Console.Write(num + " ");
    }
}