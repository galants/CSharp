using System;
class MagicNumbers
{
    static void Main(string[] args)
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int num1, num2, num3;
        bool isHasNum = false;


        for (int a = 1; a <= 7; a++)
        {
            for (int b = 1; b <= 7; b++)
            {
                for (int c = 1; c <= 7; c++)
                {
                    //Console.WriteLine("{0}{1}{2}", a, b, c);
                    num1 = int.Parse("" + a + b + c);
                    num2 = num1 + diff;
                    if (!IsAllowedNumber(num2))
                        continue;

                    num3 = num2 + diff;
                    if (!IsAllowedNumber(num3))
                        continue;

                    if (SumOfDigit(num1) + SumOfDigit(num2) + SumOfDigit(num3) == sum)
                    {
                        Console.WriteLine("" + num1 + num2 + num3);
                        isHasNum = true;
                    }
                }
            }
        }
        if(!isHasNum)
            Console.WriteLine("No");
    }

    static int SumOfDigit(int num)
    {
        int a = num/100;
        int b = (num%100)/10;
        int c = num%10;

        return (a+b+c);
    }

    static bool IsAllowedNumber(int num)
    {
        int a = num / 100;
        int b = (num % 100) / 10;
        int c = num % 10;

        return (IsAllowedDigit(a)&&IsAllowedDigit(b)&&IsAllowedDigit(c));
    }
    static bool IsAllowedDigit(int digit)
    {
        return (digit>=1&&digit<=7);
    }
}
