﻿using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> employees = new List<string>();
      //Get a name from the console and assign it to a variable
      while (true)
      {
        Console.WriteLine("Please enter a name: ");
        string input = Console.ReadLine() ?? "";
        if (input == "")
        {
          break;
        }
        employees.Add(input);        
      }
      for (int i = 0; i < employees.Count; i++)
      {
        Console.WriteLine(employees[i]);
      }
    }
  }
}