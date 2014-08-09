using System;
class WorkHours
{
    static void Main(string[] args)
    {
        int h; // hours to finish the project
        int d; // days available to finish the project
        int p; // productivity in percent
        double biking;
        double workDay;
        int efficientWorkHours;
        int differenceHours;

        h = int.Parse(Console.ReadLine());
        d = int.Parse(Console.ReadLine());
        p = int.Parse(Console.ReadLine());

        biking = (10.0 * d) / 100.0;
        workDay = (d - biking) * 12.0;
        efficientWorkHours = (int)((p * workDay)/100.0);

        differenceHours = efficientWorkHours - h;
        
        if(differenceHours<0)
            Console.WriteLine("No");
        else
            Console.WriteLine("Yes");

        Console.WriteLine(differenceHours);
    }
}
