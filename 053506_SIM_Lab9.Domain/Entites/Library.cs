using System;
using System.Collections.Generic;
using System.Text;

namespace _053506_SIM_Lab9
{
  public class Library
  {
    public Library(string name)
    {
      Name = name;
      m_BookRepository = new BookRepository();
      m_Readers = new Dictionary<string, Reader>();
    }

    public string Name { get; private set; }

    private BookRepository m_BookRepository;
    private Dictionary<string, Reader> m_Readers;
    
    public void AddReader(Reader reader)
    {
      m_Readers.Add(reader.Name, reader);
    }
    public void AddBook(Book book)
    {
      m_BookRepository.AddBook(book);
    }
    public void MakeOrder(string readerName, string bookIsbn)
    {
      if (m_Readers.ContainsKey(readerName) && m_BookRepository.IsBookExist(bookIsbn))
        m_Readers[readerName].AddBook(Name, m_BookRepository.GetBookById(bookIsbn));
      else
        throw new Exception("Reader or book not found");
    }

    private string GetReadersInfo()
    {
      StringBuilder res = new StringBuilder();

      int count = 0;
      foreach (var reader in m_Readers)
      {
        res.AppendFormat("{0}) Name: {1}\n", ++count, reader.Value.Name);
      }

      return res.ToString();
    }

    public string GetInfo()
    {
      StringBuilder res = new StringBuilder();

      res.AppendFormat("Name: {0}\n", Name);
      res.AppendFormat("Books: {0}", m_BookRepository.GetInfo());
      res.AppendFormat("Readers: {0}",GetReadersInfo());

      return res.ToString();
    }
  }
}
