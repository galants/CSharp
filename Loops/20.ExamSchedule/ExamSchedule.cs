using System;
using System.Linq;
class ExamSchedule
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 1, 5, 6, 7, 4, 3, 2 };

        Console.WriteLine(numbers.Sum()+" "+numbers.Max());
        int startHour, startMinutes;
        string partOfDay;
        int endHour, endMinutes;
        int sumMinutes, sumHours;
        int hours, minutes;

        startHour = int.Parse(Console.ReadLine());
        startMinutes = int.Parse(Console.ReadLine());
        partOfDay = Console.ReadLine();
        endHour = int.Parse(Console.ReadLine());
        endMinutes = int.Parse(Console.ReadLine());

        sumMinutes = endMinutes + startMinutes;
        sumHours = startHour + endHour + sumMinutes / 60;

        hours = sumHours % 12 == 0 ? 12 : sumHours % 12;
        minutes = sumMinutes % 60;

        if ((sumHours / 12) % 2 != 0)
        {
            if (partOfDay.Contains("AM"))
                partOfDay = "PM";
            else
                partOfDay = "AM";
        }

        Console.WriteLine("{0:00}:{1:00}:{2}", hours, minutes, partOfDay);
    }
}
