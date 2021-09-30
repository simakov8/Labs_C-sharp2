using System.Collections.Generic;

namespace _053506_SIM_Lab9
{
  public interface ISerializer
  {
    IEnumerable<Library> DeSerializeByLINQ(string fileName);
    IEnumerable<Library> DeSerializeXML(string fileName);
    IEnumerable<Library> DeSerializeJSON(string fileName);
    void SerializeByLINQ(IEnumerable<Library> libraries, string fileName);
    void SerializeXML(IEnumerable<Library> libraries, string fileName);
    void SerializeJSON(IEnumerable<Library> libraries, string fileName);
  }
}
