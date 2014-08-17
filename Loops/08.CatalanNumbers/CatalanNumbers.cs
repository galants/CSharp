using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger catalanNumber;
        BigInteger nDoubleFactDivNAdd1Fact = 1;
        BigInteger nFact = 1;

        for(int i=1; i<=n;i++)
        {
            nDoubleFactDivNAdd1Fact = nDoubleFactDivNAdd1Fact*(i + n);
            nFact = nFact*i;

        }
        catalanNumber = nDoubleFactDivNAdd1Fact / (nFact*(n+1));

        Console.WriteLine(catalanNumber);
    }
}
