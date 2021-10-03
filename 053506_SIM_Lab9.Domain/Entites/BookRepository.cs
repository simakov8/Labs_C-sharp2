using System.Collections.Generic;
using System.Text;

namespace _053506_SIM_Lab9
{
  public class BookRepository
  {
    public BookRepository()
    {
      m_Books = new Dictionary<string, Book>();
    }

    private Dictionary<string, Book> m_Books;

    public void AddBook(Book book)
    {
      m_Books.Add(book.ISBN, book);
    }
    public bool IsBookExist(string isbn)
    {
      return m_Books.ContainsKey(isbn);
    }
    public Book GetBookById(string isbn)
    {
      return m_Books[isbn];
    }
  }
}
