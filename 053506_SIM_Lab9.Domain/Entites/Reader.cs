using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053506_SIM_Lab9
{
  public class Reader
  {
    public Reader(string name)
    {
      Name = name;
      m_Books = new Dictionary<string, List<Book>>();
    }

    public string Name { get; private set; }
    private Dictionary<string, List<Book>> m_Books;

    public void AddBook(string libraryName, Book book)
    {
      if (!m_Books.ContainsKey(libraryName))
        m_Books.Add(libraryName, new List<Book>());
      m_Books[libraryName].Add(book);
    }
    public void RemoveBook(string libraryName, Book book)
    {
      if (m_Books.ContainsKey(libraryName))
        m_Books[libraryName].Remove(book);
    }
  }
}
