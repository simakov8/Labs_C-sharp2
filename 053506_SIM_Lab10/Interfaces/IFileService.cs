using System.Collections.Generic;

namespace _053506_SIM_Lab10
{
  public interface IFileService<T> where T : class
  {
    IEnumerable<T> ReadFile(string fileName);
    void SaveData(IEnumerable<T> data, string fileName);
  }
}
