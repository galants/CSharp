using System;
class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? nullIntValue = null;
        double? nullDoubleValue = null;

        Console.WriteLine("int? with \"null\" value: {0}\ndouble? with \"null\" value: {1}", nullIntValue, nullDoubleValue);
        
        nullIntValue += 13256;
        nullDoubleValue += 3.14;

        Console.WriteLine("int? with add value: {0}\ndouble? with add value: {1}.", nullIntValue, nullDoubleValue);
    }
}
