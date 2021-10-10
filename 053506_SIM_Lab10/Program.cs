using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _053506_SIM_Lab10
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Employee> employees = new List<Employee>();
      employees.Add(new Employee(10, "Yuri", false));
      employees.Add(new Employee(24, "Sveta", true));
      employees.Add(new Employee(41, "Gena", false));
      employees.Add(new Employee(5, "Evgeni", false));
      employees.Add(new Employee(19, "Liza", false));

      try
      {
        Assembly asm = Assembly.LoadFrom("053506_SIM_Lab10.Domain.dll");

        Type type = asm.GetType("_053506_SIM_Lab10.FileService`1", true, true).MakeGenericType(typeof(Employee));

        //// создаем экземпляр класса FileService
        dynamic fileService = Activator.CreateInstance(type);

        //// получаем методы
        MethodInfo ReadFile = type.GetMethod("ReadFile");
        MethodInfo SaveData = type.GetMethod("SaveData");

        SaveData.Invoke(fileService, new object[] { employees, "employees.json" });
        List<Employee> resultEmployees = new List<Employee>(ReadFile.Invoke(fileService, new object[] { "employees.json" }));
        Console.WriteLine(employees.SequenceEqual(resultEmployees));
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
