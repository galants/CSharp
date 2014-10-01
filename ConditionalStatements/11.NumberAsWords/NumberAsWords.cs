using System;
class NumberAsWords
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int firstDigit;
        int secondDigit;
        int thirdDigit;
        string str = "";

        firstDigit = number / 100;
        secondDigit = (number % 100) / 10;
        thirdDigit = number % 10;

        if (firstDigit > 0)
        {
            str += Digit(firstDigit);
            str += " hundred";
        }
        if ((firstDigit > 0) && ((number % 100) > 0))
        {
            str += " and ";
        }
        if (((number % 100) > 10) && ((number % 100) < 20))
        {
            str += DigitTeen((number % 100));
        }
        else if (secondDigit > 0)
        {
            str += DigitTy(secondDigit);

            if (thirdDigit > 0)
            {
                str += " " + Digit(thirdDigit);
            }
        }
        if (firstDigit == 0 && secondDigit == 0)
        {
            str += Digit(thirdDigit);
        }
        Console.WriteLine(UppercaseFirst(str));
    }

    static string Digit(int num)
    {
        switch (num)
        {
            case 0: return "zero"; break;
            case 1: return "one"; break;
            case 2: return "two"; break;
            case 3: return "three"; break;
            case 4: return "four"; break;
            case 5: return "five"; break;
            case 6: return "six"; break;
            case 7: return "seven"; break;
            case 8: return "eight"; break;
            case 9: return "nine"; break;
            default: return ""; break;
        }
    }
    static string DigitTy(int num)
    {
        switch (num)
        {
            case 1: return "ten"; break;
            case 2: return "twenty"; break;
            case 3: return "thirty"; break;
            case 4: return "fourty"; break;
            case 5: return "fifty"; break;
            case 6: return "sixty"; break;
            case 7: return "seventy"; break;
            case 8: return "eighty"; break;
            case 9: return "ninety"; break;
            default: return ""; break;
        }
    }
    static string DigitTeen(int num)
    {
        switch (num)
        {
            case 11: return "eleven"; break;
            case 12: return "twelve"; break;
            case 13: return "thirteen"; break;
            case 14: return "fourteen"; break;
            case 15: return "fifteen"; break;
            case 16: return "sixteen"; break;
            case 17: return "seventeen"; break;
            case 18: return "eighteen"; break;
            case 19: return "nineteen"; break;
            default: return ""; break;
        }
    }
    static string UppercaseFirst(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return string.Empty;
        }
        return char.ToUpper(str[0]) + str.Substring(1);
    }
}