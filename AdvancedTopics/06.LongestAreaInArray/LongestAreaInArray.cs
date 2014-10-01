using System;

internal class LongestAreaInArray
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] strArray = new string[n];
        int maxNumElement = 1;
        int count = 1;
        string maxElement = "";

        for (int i = 0; i < n; i++)
        {
            strArray[i] = Console.ReadLine();
        }

        maxElement = strArray[0];

        for (int i = 1; i < strArray.Length; i++)
        {
            string last = strArray[i - 1];

            if ((strArray[i].Equals(last)))
            {
                count++;
            }
            else
            {
                count = 1;
            }

            if (count > maxNumElement)
            {
                maxNumElement = count;
                maxElement = strArray[i];
            }
            else if (count == maxNumElement)
            {
                if (maxElement.Length < strArray[i].Length)
                    maxElement = strArray[i];
            }
        }
        Console.WriteLine(maxNumElement);

        for (int i = 0; i < maxNumElement; i++)
            Console.WriteLine(maxElement);
    }
}