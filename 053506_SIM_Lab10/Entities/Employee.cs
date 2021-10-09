namespace _053506_SIM_Lab1
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
  }
}
