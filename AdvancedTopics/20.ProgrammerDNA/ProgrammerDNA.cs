using System;
class ProgrammerDNA
{
    static void Main(string[] args)
    {
        int lenght = 7;
        int count = 1;
        bool isUp = true;

        int n = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine().ToUpper());

        for (int i = 1; i <= n; i++)
        {
            if (count == 7)
            {
                isUp = !isUp;
            }
            else if (count < 0)
            {
                isUp = !isUp;
                count = 1;
            }

            for (int j = 0; j < (lenght - count) / 2; j++)
                Console.Write('.');

            for (int j = 0; j < count; j++)
            {                
                Console.Write(ch++);
                
                if (ch > 71)
                {
                    ch = (char)65;
                }
            }
            for (int j = 0; j < (lenght-count) / 2; j++)
                Console.Write('.');
            
            if (isUp)
                count += 2;
            else
                count -= 2;

            Console.WriteLine();
            
        }
    }
}