using System;
class GravitationOnTheMoon
{
    static void Main(string[] args)
    {
        double weight = double.Parse(Console.ReadLine());
        double weightOnMoon = weight * 0.17;

        Console.WriteLine(weightOnMoon);
    }
}