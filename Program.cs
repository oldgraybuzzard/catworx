using System;
using System.Collections.Generic;


namespace CatWorx.BadgeMaker
{
  class Program
  {
    static List<Employee> GetEmployees()
    {
      List<Employee> employees = new List<Employee>();
      while(true)
      {
        Console.WriteLine("Please enter first name: (leave empty to exit): ");
        string firstName = Console.ReadLine() ?? "";
        if (firstName == "")
        {
          break;
        }
        // Add Console.ReadLine for each value
        Console.Write("Enter last name: ");
        string lastName = Console.ReadLine() ?? "";
        Console.Write("Enter Employee ID: ");
        int id = Int32.Parse(Console.ReadLine() ?? "");
        Console.Write("Enter the URL for the photo: ");
        string photoUrl = Console.ReadLine() ?? "";
        Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
        // add currentEmployee
        employees.Add(currentEmployee);
      }
      return employees;
    }

    static void PrintEmployees(List<Employee> employees)
    {
      for (int i = 0; i < employees.Count; i++)
      {
        string template = "{0, 10}\t{1,20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
      }
    }
    static void Main(string[] args)
    {
      //This is our employee-getting code
      List<Employee> employees = GetEmployees();
      PrintEmployees(employees);
    }
  }
}