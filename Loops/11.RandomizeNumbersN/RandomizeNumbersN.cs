using System;
class RandomizeNumbersN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Random rnd = new Random(n);

        for (int i = 0; i < n; i++)
        {
            int newNuw = rnd.Next(1, n+1);
            bool isHasUniqueValue = true;

            do
            {
                for (int j=0;j<i;j++)
                {
                   
                    if (numbers[j] == newNuw)
                    {
                        isHasUniqueValue = false;
                        newNuw = rnd.Next(1,n+1);
                        break;
                    }
                    else
                    {
                        isHasUniqueValue = true;
                    }
                }
            } while (!isHasUniqueValue);

            numbers[i] = newNuw;
        }
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}
