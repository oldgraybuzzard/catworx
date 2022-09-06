using System;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Util
  {
    //Method declared as "Static"
    public static void PrintEmployees(List<Employee> employees)
    {
      for (int i = 0; i < employees.Count; i++)
      {
        string template = "{0, 10}\t{1,20}\t{2}";
        Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
      }
    }
     public static void MakeCSV(List<Employee> employees)
     {
      // check to see if data folder exists
      if (!Directory.Exists("data"))
      {
        //if it does not exist, create the directory
        Directory.CreateDirectory("data");
      }
      using (StreamWriter file = new StreamWriter("data/employees.csv"))
      {
        file.WriteLine("ID,Name,PhotoUrl");
      for (int i = 0; i < employees.Count; i++)
        {
          string template = "{0},{1},{2}";
          file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
        }
      }
    }
  }
}