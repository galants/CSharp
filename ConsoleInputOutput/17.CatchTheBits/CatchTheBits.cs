using System;
class CatchTheBits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int number;
        int newNumber = 0;
        int index = 1;
        int setPosition = 0;

        for (int i = 0; i < n; i++)
        {
            number = int.Parse(Console.ReadLine());

            for (; index < 8; index = (index + step))
            {
                if ((number & (1 << (7 - index))) > 0)
                {
                    newNumber = (newNumber << 1) + 1;
                }
                else
                {
                    newNumber = (newNumber << 1);
                }
                setPosition++;
            }
            index = index % 8;
            if (setPosition > 7)
            {
                setPosition -= 8;
                Console.WriteLine(newNumber);

                newNumber = 0;
            }
        }

        int addPosiston = setPosition % 8;
        if (addPosiston != 0)
            newNumber = newNumber << (8 - addPosiston);

        Console.WriteLine(newNumber);
    }
}
