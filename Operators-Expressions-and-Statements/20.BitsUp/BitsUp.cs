using System;
class BitsUp
{
    static void Main(string[] args)
    {
        byte n;
        int step;
        int next = 1;
        byte num;

        n = byte.Parse(Console.ReadLine());
        step = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            num = byte.Parse(Console.ReadLine());

            while (next < 8 && step > 0)
            {
                byte mask = (byte)(1 << (7 - next));

                num = (byte)(num | mask);
                next += step;
            }

            next = next - 8;

            Console.WriteLine(num);
        }
    }
}