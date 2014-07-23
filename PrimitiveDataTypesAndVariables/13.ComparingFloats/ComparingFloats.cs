using System;
class ComparingFloats
{
    static void Main(string[] args)
    {
        double a, b;

        a = 5.3;
        b = 6.01;
        Console.WriteLine("is Equal: {0}", isEqual(a,b));

        a = 5.00000001;
        b = 5.00000003;
        Console.WriteLine("is Equal: {0}", isEqual(a, b));

        a = 5.00000005;
        b = 5.00000001;
        Console.WriteLine("is Equal: {0}", isEqual(a, b));

        a = -0.0000007;
        b = 0.0000007;
        Console.WriteLine("is Equal: {0}", isEqual(a, b));

        a = -4.999999;
        b = -4.999998;
        Console.WriteLine("is Equal: {0}", isEqual(a, b));

        a = 4.999999;
        b = 4.999998;
        Console.WriteLine("is Equal: {0}", isEqual(a, b));
    }

    static bool isEqual(double a, double b)
    {
        double eps = 0.000001;
        double difference = Math.Abs(a - b);
        bool isEqual = false;

        if(difference<eps)
        {
            isEqual = true; 
        }

        return isEqual;
    }
}