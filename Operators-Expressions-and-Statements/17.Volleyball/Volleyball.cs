using System;
class Volleyball
{
    static void Main(string[] args)
    {
        string Year;
        short p;
        byte h;
        double addPlayTimes = 1.0;
        byte weekends = 48;
        double playWeekends, playHometownWeekends, playHoliday, playFootball;

        Year = Console.ReadLine();
        p = short.Parse(Console.ReadLine()); //number of holidays
        h = byte.Parse(Console.ReadLine());  //number of weekends that Joro spends in his hometown

        if (Year.Equals("leap"))
            addPlayTimes = 1.15;

        playHometownWeekends = h;
        playWeekends = (weekends - h) * 3.0 / 4.0;
        playHoliday = p * 2.0 / 3.0;
        playFootball = (playHoliday + playHometownWeekends + playWeekends) * addPlayTimes;

        Console.WriteLine((int)playFootball);
    }
}
