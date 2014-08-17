using System;
class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int num = 0;
        int pos = 1;


        for (int i = str.Length - 1; i >= 0; i--, pos *= 2)
        {
            num += int.Parse(str[i].ToString()) * pos;
        }

        Console.WriteLine(num);
    }
}