using System;

internal class MatrixOfPalindromes
{
    private static void Main(string[] args)
    {
        char first = 'a';
        char midle = 'a';
        string str = Console.ReadLine();
        string[] strArr = str.Split(new char[] {' '});

        int r = int.Parse(strArr[0]);
        int c = int.Parse(strArr[1]);


        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                if (j > 0 && j < c)
                    Console.Write(" ");

                Console.Write("{0}{1}{0}", (char) (first + i), (char) (midle + j + i));
            }
            Console.WriteLine();
        }
    }
}