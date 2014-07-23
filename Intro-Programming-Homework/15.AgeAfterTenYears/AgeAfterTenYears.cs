using System;
class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        Console.Write("Enter your birthday (in format dd.mm.yyyy): ");

        string strBirthday = Console.ReadLine();
        DateTime birthday = DateTime.Parse(strBirthday);

        long resulut = DateTime.Today.Subtract(birthday).Ticks;

        int ageNow = new DateTime(resulut).Year - 1;

        Console.WriteLine("You are {0} years old.", ageNow);
        Console.WriteLine("After 10 years you will be {0} years old.", ageNow + 10);
    }
}