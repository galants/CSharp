using System;
class WinningNumbers
{
    static void Main()
    {
        string s = Console.ReadLine();
        s = s.ToLower();
        int sum = 0;
        bool isHasWinningNumber = false;

        for (int i = 0; i < s.Length; i++)
        {
            char ch = s[i];
            sum += (int)ch - 96;
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 10; k++)
                {
                    for (int l = 0; l < 10; l++)
                    {
                        for (int m = 0; m < 10; m++)
                        {
                            for (int n = 0; n < 10; n++)
                            {
                                int productFirstNumbers = i * j * k;
                                int productSecondNumbers = l * m * n;

                                if (productFirstNumbers == sum && productSecondNumbers == sum)
                                {
                                    Console.WriteLine("{0}{1}{2}-{3}{4}{5}", i, j, k, l, m, n);
                                    isHasWinningNumber = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        if (!isHasWinningNumber)
        {
            Console.WriteLine("No");
        }
    }
}
