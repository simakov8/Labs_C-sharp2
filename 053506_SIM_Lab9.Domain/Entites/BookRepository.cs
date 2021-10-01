using System.Collections.Generic;

namespace _053506_SIM_Lab9
{
  public class BookRepository
  {
    public BookRepository()
    {
      CountOfBooks = 0;
      m_Books = new Dictionary<string, Book>();
    }

    public int CountOfBooks { get; private set; }
    private Dictionary<string, Book> m_Books;

    public void AddBook(Book book)
    {
      m_Books.Add(book.ISBN, book);
    }
    public Book GetBookById(string isbn)
    {
      return m_Books[isbn];
    }
  }
}
