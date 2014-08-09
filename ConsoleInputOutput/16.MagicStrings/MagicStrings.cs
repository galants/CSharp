using System;
class MagicStrings
{
    static void Main(string[] args)
    {
        int[] values = { 3, 5, 4, 1 };
        char[] chars = { 's', 'p', 'n', 'k' };
        int[] numbers = new int[8];
        char[] strCahrs = new char[8];
        int diff;
        bool isHasMagicString = false;


        diff = int.Parse(Console.ReadLine());

        for (int h = 3; h >= 0; h--)
        {
            for (int j = 3; j >= 0; j--)
            {
                for (int k = 3; k >= 0; k--)
                {
                    for (int l = 3; l >= 0; l--)
                    {
                        for (int y = 3; y >= 0; y--)
                        {
                            for (int u = 3; u >= 0; u--)
                            {
                                for (int i = 3; i >= 0; i--)
                                {
                                    for (int o = 3; o >= 0; o--)
                                    {
                                        int difference = Math.Abs((values[o] + values[i] + values[u] + values[y]) - (values[l] + values[k] + values[j] + values[h]));

                                        if (difference == diff)
                                        {
                                            string str = "" + chars[h] + chars[j] + chars[k] + chars[l] + chars[y] + chars[u] + chars[i] + chars[o];
                                            Console.WriteLine(str);

                                            isHasMagicString = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (!isHasMagicString)
            Console.WriteLine("No");
    }
    static int DifferenceOfNumber(int[] numbers)
    {
        int sumLeft = 0;
        int sumRight = 0;
        int difference;

        for (int i = 0; i < 4; i++)
            sumLeft += numbers[i];

        for (int i = 4; i < 8; i++)
            sumRight += numbers[i];

        difference = Math.Abs(sumLeft - sumRight);
        return difference;
    }
}
