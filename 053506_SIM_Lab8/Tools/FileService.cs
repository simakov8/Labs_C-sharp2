using System.Collections.Generic;
using System.IO;

namespace _053506_SIM_Lab8
{
  class FileService : IFileService
  {
    public IEnumerable<Employee> ReadFile(string fileName)
    {
      if (!File.Exists(fileName))
        throw new FileNotFoundException();

      using (BinaryReader reader = new BinaryReader(File.OpenRead(fileName)))
      {
        while (reader.PeekChar() > -1)
        {
          string name = reader.ReadString();
          int age = reader.ReadInt32();
          bool isMarried = reader.ReadBoolean();

          yield return new Employee(name, age, isMarried);
        }
      }
    }

    public void SaveData(IEnumerable<Employee> data, string fileName)
    {
      if (!File.Exists(fileName))
        throw new FileNotFoundException();

      using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(fileName)))
      {
        foreach (var employee in data)
        {
          writer.Write(employee.Name);
          writer.Write(employee.Age);
          writer.Write(employee.IsMarried);
        }
      }
    }
  }
}
