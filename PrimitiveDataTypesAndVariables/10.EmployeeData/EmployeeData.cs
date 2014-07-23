using System;
class EmployeeData
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.firstName = "Vencislav";
        employee.lastName = "Nikolov";
        employee.age = 32;
        employee.gender = 'm';
        employee.idNum = 8306112507;
        employee.employeeNum = 9999;

        employee.PrintEmployeeData();

    }
}
class Employee
{
    public string firstName{ get; set;}
    public string lastName{ get; set;}
    public byte age{ get; set;}
    public char gender{ get; set;}
    public long idNum{ get; set;}
    public int employeeNum{ get; set;}
    public Employee() { }

    public Employee(string firstName, string lastName, byte age, 
        char gender, long idNum, int employeeNum)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.gender = gender;
        this.idNum = idNum;
        this.employeeNum = employeeNum;
    }

    public void PrintEmployeeData()
    {
        Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nGender: {3}\nId Num: {4}\nEmployee Number: {5}", firstName, lastName, age, gender, idNum, employeeNum);
    }
}