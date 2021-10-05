using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _053506_SIM_Lab9
{
  public class BookRepository : IEnumerable<Book>
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

    public IEnumerator<Book> GetEnumerator()
    {
      foreach (var book in m_Books)
        yield return book.Value;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new System.NotImplementedException();
    }

    public bool Equals(BookRepository books)
    {
      return books.m_Books.OrderBy(kvp => kvp.Key).SequenceEqual(books.m_Books.OrderBy(kvp => kvp.Key));
    }
  }
}
