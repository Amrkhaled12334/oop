
namespace MyConsoleApp
{
using System;

public enum SecurityLevel
{
    Guest,
    Developer,
    Secretary,
    DBA
}

public class HiringDate
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public HiringDate(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    public override string ToString()
    {
        return $"{Day}/{Month}/{Year}";
    }
}

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public char Gender { get; set; }
    public SecurityLevel SecurityLevel { get; set; }  // This property now refers to a public enum
    public double Salary { get; set; }
    public HiringDate HireDate { get; set; }

    public Employee(int id, string name, char gender, SecurityLevel securityLevel, double salary, HiringDate hireDate)
    {
        ID = id;
        Name = name;
        Gender = gender;
        SecurityLevel = securityLevel;
        Salary = salary;
        HireDate = hireDate;
    }

    public override string ToString()
    {
        return $"{Name} ({SecurityLevel}): Salary: {String.Format("{0:C}", Salary)}, Hire Date: {HireDate}";
    }
}
}