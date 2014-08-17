using System;
class PrintDeck52Cards
{
    static void Main(string[] args)
    {
        string[] rank ={"2","3","4","5","6","7","8","9","10","J","Q","K","A" };
        string[] colors = { "\u2663", "\u2665", "\u2666", "\u2660" };
        
        for (int i = 2; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (j)
                {
                    case 0:
                        Console.Write("{0}{1}", rank[i], colors[j]);
                        break;
                    case 1:
                        Console.Write("{0}{1}", rank[i], colors[j]);
                        break;
                    case 2:
                        Console.Write("{0}{1}", rank[i], colors[j]);
                        break;
                    case 3:
                        Console.Write("{0}{1}", rank[i], colors[j]);
                        break;
                }
                Console.Write("\t");
            }
            Console.WriteLine();
        }
    }
}