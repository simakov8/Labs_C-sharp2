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
    }

    public string Name { get; private set; }

    private BookRepository m_BookRepository;
    
    public void AddBook(Book book)
    {
      m_BookRepository.AddBook(book);
    }
  }
}
