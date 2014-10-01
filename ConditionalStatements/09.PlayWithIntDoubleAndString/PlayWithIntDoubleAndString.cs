using System;
class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Please enter an int: ");
                int integerNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(integerNumber + 1);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleNumber + 1);
                break;
            case 3:
                Console.Write("Please enter a string: ");
                string str = Console.ReadLine();
                Console.WriteLine("{0}{1}", str.ToString(), '*');
                break;
            default: break;
        }
    }
}
