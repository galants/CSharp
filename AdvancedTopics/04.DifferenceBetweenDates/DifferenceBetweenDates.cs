using System;
using System.Globalization;

internal class DifferenceBetweenDates
{
    private static void Main(string[] args)
    {
        DateTime startDate;
        DateTime endDate;
        int dateBetweenDates;

        DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, DateTimeStyles.None, out startDate);
        DateTime.TryParseExact(Console.ReadLine(), "dd.MM.yyyy", null, DateTimeStyles.None, out endDate);

        dateBetweenDates = (int) (endDate - startDate).TotalDays;

        Console.WriteLine(dateBetweenDates);
    }
}