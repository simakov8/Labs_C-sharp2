using System;

namespace _053506_SIM_Lab9
{
  [Serializable]
  public class Library
  {
    public Library() { }
    public Library(string name)
    {
      Name = name;
      BookRepository = new BookRepository();
    }

    public string Name { get; set; }

    public BookRepository BookRepository { get; set; }

    public void AddBook(Book book)
    {
      BookRepository.Add(book);
    }

    public override bool Equals(object lib)
    {
      if (lib is Library)
      {
        Library library = (Library)lib;
        return (Name == library.Name) && BookRepository.Equals(library.BookRepository);
      }
      return false;
    }
  }
}
