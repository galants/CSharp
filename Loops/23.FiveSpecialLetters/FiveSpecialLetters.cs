using System;
class FiveSpecialLetters
{
    static int start;
    static int end;
    static int[] weights = new int[] { 5, -12, 47, 7, -32 };
    static char[] chars = new char[] { 'a', 'b', 'c', 'd', 'e' };
    static bool isHasSequence = false;
    static void Main(string[] args)
    {
        start = int.Parse(Console.ReadLine());
        end = int.Parse(Console.ReadLine());

        for (int a = 0; a < chars.Length; a++)
        {
            for (int b = 0; b < chars.Length; b++)
            {
                for (int c = 0; c < chars.Length; c++)
                {
                    for (int d = 0; d < chars.Length; d++)
                    {
                        for (int e = 0; e < chars.Length; e++)
                        {
                            Print(a, b, c, d, e);
                        }
                    }
                }
            }
        }


        if (!isHasSequence)
            Console.Write("No");
    }

    static void Print(int a, int b, int c, int d, int e)
    {

        int weight = 0;
        string str = "";

        weight = weights[a];
        str += chars[a];
        int i = 2;

        if (b != a)
        {
            str += chars[b];
            weight += i++ * weights[b];
        }

        if ((c != a) && (c != b))
        {
            str += chars[c];
            weight += i++ * weights[c];
        }

        if (((d != a) && (d != b)) && (d != c))
        {
            str += chars[d];
            weight += i++ * weights[d];
        }

        if (((e != a) && (e != b)) && ((e != c) && (e != d)))
        {
            str += chars[e];
            weight += i * weights[e];
        }

        if (weight >= start && weight <= end)
        {

            if (isHasSequence)
                Console.Write(' ');

            isHasSequence = true;
            Console.Write("{0}{1}{2}{3}{4}", chars[a], chars[b], chars[c], chars[d], chars[e]);
        }
    }
}
