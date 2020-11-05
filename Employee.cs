using System;
class Employee
{
  private string firstname;
  private string lastname;
  private int age;//validation must be less than 18, else set as 18
  private double YearlySalary;//validation must be set as 1000, else set as 1000
  private string id;
  private string EmploymentStatus;



  public Employee()
  {
    firstname = "unknown";
    lastname = "unknown";
    age = 0;
    id = "unknown";
    YearlySalary = 0;
    EmploymentStatus = "inactive";


  }

  public Employee(string first, string last, int agee, string idd, double salary, string status)
  {
    double sal = 1000;
    if (salary > sal)
    {
      sal = salary;
    }
    int ageee = 18;
    if (agee > ageee)
    {
      ageee = agee;
    }
    firstname = first;
    lastname = last;
    age = ageee;
    id = idd;
    YearlySalary = sal;
    EmploymentStatus = status;

    

  }

  public void intro()
  {
   
    Console.WriteLine("First name: " + firstname);
    Console.WriteLine("Last name: " + lastname);
    Console.WriteLine("Age: " + Convert.ToString(age));
    Console.WriteLine("ID: " + id);
    Console.WriteLine("Yearly Salary: " + YearlySalary);
  
  }

  public void IncreaseSalary(double pctg)
  {
    double newsal = (((pctg/100) * YearlySalary) + (YearlySalary));
    if (pctg < 0)
    {
      Console.WriteLine("Invalid input. Yearly Salary not updated.");
    }
    else
    {
      Console.WriteLine("Yearly salary updated to " + newsal);
    }
  }
  public void RemoveEmployee()
  {
    if (EmploymentStatus == "inactive")
    {
      Console.WriteLine("Employee already inactive.");
    }
    else
    {
      EmploymentStatus = "inactive";
      Console.WriteLine("Employee removed successfully!!!");
    }
  }


}