using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _053506_SIM_Lab8
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Employee> employees1 = new List<Employee>();
      employees1.Add(new Employee("Ivan", 34, true));
      employees1.Add(new Employee("Petr", 46, false));
      employees1.Add(new Employee("Gena", 28, false));
      employees1.Add(new Employee("Anatoli", 30, true));
      employees1.Add(new Employee("Yuri", 19, false));

      string path1 = @".\employees1.dat";
      string path2 = @".\employees2.dat";

      using (File.Create(path1)) { };

      FileService fileService = new FileService();
      fileService.SaveData(employees1, path1);

      File.Delete(path2);
      File.Move(path1, path2);

      List<Employee> employees2 = new List<Employee>(fileService.ReadFile(path2));
      var sorted = employees2.OrderBy(empl => empl, new EmployeeComparer());

      foreach (Employee employee in employees1)
        employee.ShowInfo();

      Console.WriteLine();

      foreach (Employee employee in sorted)
        employee.ShowInfo();
    }
  }
}
