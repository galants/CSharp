using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateNK
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int k;
            int cal = 1;

            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());

            for (int i = k+1; i <= n; i++)
            {
                cal *= i;
            }

            Console.WriteLine(cal);
        }
    }
}
