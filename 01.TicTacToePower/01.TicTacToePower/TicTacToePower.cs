using System;
class TicTacToePower
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());

        int index = y*3 + x+1;

        int value = v + index - 1;

        decimal result = 1;
        for (int i = 0; i < index; i++)
        {
            result *= value;
        }

        Console.WriteLine(result);

    }
}
