using System;
using System.Globalization;
class BeerTime
{
    static void Main(string[] args)
    {
        string str;
        DateTime time = new DateTime();

        str = Console.ReadLine();
        bool checkFormat = DateTime.TryParseExact(str, "h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out time);
        DateTime startTime = DateTime.Parse("1:00 PM");
        DateTime endTime = DateTime.Parse("3:00 AM");

        if (checkFormat)
        {
            if (time >= startTime || time < endTime)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
        else
        {
            Console.WriteLine("invalid time");
        }
    }
}
