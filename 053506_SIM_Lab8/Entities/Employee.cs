using System;

namespace _053506_SIM_Lab8
{
  class Employee
  {
    public Employee(string name, int age, bool isMarried)
    {
      Name = name;
      Age = age;
      IsMarried = isMarried;
    }

    public int Age { get; set; }
    public bool IsMarried { get; set; }
    public string Name { get; private set; }

    public void ShowInfo()
    {
      Console.WriteLine("Name: {0}, Age: {1}, Is Married: {2}", Name, Age, IsMarried);
    }
  }
}
