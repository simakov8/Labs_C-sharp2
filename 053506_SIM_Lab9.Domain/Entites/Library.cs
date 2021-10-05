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
      BookRepository = new BookRepository();
    }

    public string Name { get; private set; }

    public BookRepository BookRepository { get; private set; }
    
    public void AddBook(Book book)
    {
      BookRepository.AddBook(book);
    }

    public override bool Equals(object lib)
    {
      Library library = (Library)lib;
      return (Name == library.Name) && BookRepository.Equals(library.BookRepository);
    }
  }
}
