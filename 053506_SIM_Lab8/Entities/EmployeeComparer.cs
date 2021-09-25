using System.Collections.Generic;

namespace _053506_SIM_Lab8
{
  class EmployeeComparer : IComparer<Employee>
  {
    public int Compare(Employee x, Employee y)
    {
      return x.Name.CompareTo(y.Name);
    }
  }
}
