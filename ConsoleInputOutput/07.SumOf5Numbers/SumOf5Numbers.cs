using System;
class SumOf5Numbers
{
    static void Main(string[] args)
    {
        string str;
        string[] strNumbers;
        double sum = 0;

        str = Console.ReadLine();
        strNumbers = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string strNum in strNumbers)
            sum += double.Parse(strNum);

        Console.WriteLine(sum);
    }
}