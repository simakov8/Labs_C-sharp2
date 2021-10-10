using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053506_SIM_Lab10
{
  public class FileService<T> : IFileService<T> where T : class
  {
    public IEnumerable<T> ReadFile(string fileName)
    {
      using (StreamReader file = File.OpenText(fileName))
      {
        JsonSerializer serializer = new JsonSerializer();
        T[] libraries = (T[])serializer.Deserialize(file, typeof(T[]));
        return libraries;
      }
    }

    public void SaveData(IEnumerable<T> data, string fileName)
    {
      using (StreamWriter file = File.CreateText(fileName))
      {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Serialize(file, data);
      }
    }
  }
}
