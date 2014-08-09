using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        string str;
        string companyName;
        string companyAddress;
        string companyPhoneNumber;
        string companyFaxNumber;
        string companyWebSite;
        string managerFirstName;
        string managerLastName;
        string managerAge;
        string managerPhoneNumber;

        Console.Write("Company name:");
        companyName = Console.ReadLine();

        Console.Write("Company address:");
        companyAddress = Console.ReadLine();

        Console.Write("Phone number:");
        companyPhoneNumber = Console.ReadLine();

        Console.Write("Fax number:");
        str = Console.ReadLine();
        companyFaxNumber = string.IsNullOrEmpty(str)?"(no fax)":str;

        Console.Write("Web site:");
        companyWebSite = Console.ReadLine();

        Console.Write("Manager first name:");
        managerFirstName = Console.ReadLine();

        Console.Write("Manager last name:");
        managerLastName = Console.ReadLine();

        Console.Write("Manager age:");
        managerAge = Console.ReadLine();

        Console.Write("Manager phone:");
        managerPhoneNumber = Console.ReadLine();

        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", companyPhoneNumber);
        Console.WriteLine("Fax: {0}", companyFaxNumber);
        Console.WriteLine("Web site: {0}", companyWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}
