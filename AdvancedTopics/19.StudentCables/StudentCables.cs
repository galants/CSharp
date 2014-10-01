using System;
using System.Collections.Generic;

internal class StudentCables
{
    private static void Main(string[] args)
    {
        int lose = 0;
        int countStdentCables = 0;
        int lenghtStdentCables = 0;
        int lenghtCable = 0;
        int n = int.Parse(Console.ReadLine());
        List<int> lines = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int lenght = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            if (str.Equals("meters"))
            {
                lenght *= 100;
            }

            if (lenght >= 20)
                lines.Add(lenght);
        }

        foreach (int cabel in lines)
            lenghtCable += cabel;

        lenghtCable -= 3*(lines.Count - 1);
        lenghtStdentCables = 5*100 + 2*2;

        lose = lenghtCable%lenghtStdentCables;
        countStdentCables = lenghtCable/lenghtStdentCables;

        Console.WriteLine(countStdentCables);
        Console.WriteLine(lose);
    }
}