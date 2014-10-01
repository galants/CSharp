using System;
class BonusScore
{
    static void Main(string[] args)
    {
        int num;

        num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
            case 2:
            case 3:
                num *= 10;
                Console.WriteLine(num);
                break;
            case 4:
            case 5:
            case 6:
                num *= 100;
                Console.WriteLine(num);
                break;
            case 7:
            case 8:
            case 9:
                num *= 1000;
                Console.WriteLine(num);
                break;
            default:
                Console.WriteLine("invalid score");
                break;
        }
    }
}
