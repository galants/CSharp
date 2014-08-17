using System;
class CalculateNKNK
{
    static void Main(string[] args)
    {
        int nFactDivKFact = 1;
        int nSubKFact = 1;
        int n;
        int k;

        n = int.Parse(Console.ReadLine());

        k = int.Parse(Console.ReadLine());

        for (int i = k + 1; i <= n; i++)
        {
            nFactDivKFact *= i;
        }

        for (int i = 1; i <= n-k; i++)
        {
            nSubKFact *= i;
        }
        Console.WriteLine(nFactDivKFact/nSubKFact);

    }
}
