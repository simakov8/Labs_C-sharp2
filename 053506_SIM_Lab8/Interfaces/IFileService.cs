using System.Collections.Generic;

namespace _053506_SIM_Lab8
{
  interface IFileService
  {
    IEnumerable<Employee> ReadFile(string fileName);
    void SaveData(IEnumerable<Employee> data, string fileName);
  }
}
