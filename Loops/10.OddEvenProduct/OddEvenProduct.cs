using System;
class OddEvenProduct
{
    static void Main(string[] args)
    {
        string str;
        int oddProduct=1;
        int evenProduct=1;

        str = Console.ReadLine();

        string[] strings = str.Split(' ');

        for (int i = 1; i <= strings.Length;i++ )
        {
            int num = int.Parse(strings[i-1]);

            if (i % 2 == 0)
            {
                evenProduct *= num;
            }
            else
            {
                oddProduct *= num;
            }
        }

        if(oddProduct==evenProduct)
        {
            Console.WriteLine("yes\nproduct = " + oddProduct);
        }
        else
        {
            Console.WriteLine("no\nodd_product = " + oddProduct+"\n"+"even_product = " + evenProduct);
        }
    }
}
