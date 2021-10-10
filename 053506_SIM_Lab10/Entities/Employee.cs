namespace _053506_SIM_Lab10
{
  class Employee
  {
    public Employee(int age, string name, bool isMarried)
    {
      Age = age;
      Name = name;
      IsMarried = isMarried;
    }
    public int Age { get; set; }
    public string Name { get; set; }
    public bool IsMarried { get; set; }

    public override bool Equals(object obj)
    {
      Employee employee = (Employee)obj;
      return (Age == employee.Age) && (Name == employee.Name) && (IsMarried == employee.IsMarried);
    }
  }
}
