using System;

class MainClass {
  public static void Main (string[] args) {
    Employee employee1 = new Employee();
    employee1.intro();
    Employee employee2 = new Employee("Robert", "Downey", 12, "12321", 100, "active");
    employee2.intro();
    Employee employee3 = new Employee("John", "Smith", 38, "S0089", 50000, "active");
    employee3.intro();
    employee3.IncreaseSalary(-2);
    employee3.RemoveEmployee();
    Employee employee4 = new Employee("Maria", "Lambert", 26, "S0100", 80000, "active");
    employee4.intro();
    employee4.IncreaseSalary(7);
    employee4.RemoveEmployee();
    employee4.RemoveEmployee();
  }
}