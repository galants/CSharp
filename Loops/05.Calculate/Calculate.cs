using System;
class Calculate
{
    static void Main(string[] args)
    {
        int n;
        int x;
        double sum = 1.0;
        int nFact=1;
        int xMult=1;
        
        n = int.Parse(Console.ReadLine());
        x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
            xMult *= x;
            sum += (double)nFact / (double)xMult;
        }
        Console.WriteLine("{0:F5}",sum);
    }
}
