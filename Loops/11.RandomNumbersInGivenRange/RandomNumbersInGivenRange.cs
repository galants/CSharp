using System;
class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int n;
        int min;
        int max;

        n = int.Parse(Console.ReadLine());
        min = int.Parse(Console.ReadLine());
        max = int.Parse(Console.ReadLine());

        
        for(int i=0;i<n;i++)
        {
            Console.Write(rnd.Next(min, max));
            Console.Write(" ");
        }
            
    }
}
