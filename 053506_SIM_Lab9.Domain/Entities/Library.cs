using System.Collections.Generic;

namespace _053506_SIM_Lab9
{
  public class Library
  {
    public Library(string name)
    {
      Name = name;
      CountOfReaders = 0;
      m_BookRepository = new BookRepository();
      m_Readers = new Dictionary<string, Reader>();
    }

    public string Name { get; private set; }
    public int CountOfReaders { get; private set; }
    private BookRepository m_BookRepository;
    private Dictionary<string, Reader> m_Readers;
    
    public void AddReader(Reader reader)
    {
      m_Readers.Add(reader.Name, reader);
    }
    public void MakeOrder(string readerName, string bookIsbn)
    {
      m_Readers[readerName].AddBook(Name, m_BookRepository.GetBookById(bookIsbn));
    }
  }
}
