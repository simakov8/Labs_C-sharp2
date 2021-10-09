using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053506_SIM_Lab10
{
  public class FileService<T> : IFileService<T> where T : class
  {
    public IEnumerable<T> ReadFile(string fileName)
    {
      throw new NotImplementedException();
    }

    public void SaveData(IEnumerable<T> data, string fileName)
    {
      throw new NotImplementedException();
    }
  }
}
