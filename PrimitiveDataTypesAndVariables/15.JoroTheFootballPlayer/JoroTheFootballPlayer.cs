using System;
class JoroTheFootballPlayer
{
    static void Main(string[] args)
    {
        string Year;
        short p;
        byte h;
        byte addPlayTimes=0;
        byte weekends = 52;
        double playWeekends, playHometownWeekends, playHoliday, playFootball;

        Year = Console.ReadLine();
        p = short.Parse(Console.ReadLine()); //number of holidays
        h = byte.Parse(Console.ReadLine());  //number of weekends that Joro spends in his hometown

        if (Year.Equals("t"))
            addPlayTimes = 3;
        
        playHometownWeekends = h;
        playWeekends = (weekends - h) * 2.0/ 3.0;
        playHoliday = p / 2.0;
        playFootball = (playHoliday + playHometownWeekends + playWeekends + addPlayTimes);

        Console.WriteLine((int)playFootball);
        


    }
}