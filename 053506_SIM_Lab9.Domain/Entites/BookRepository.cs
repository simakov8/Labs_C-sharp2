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

    public string GetInfo()
    {
      StringBuilder res = new StringBuilder();

      int count = 0;
      foreach (var book in m_Books)
      {
        res.AppendFormat("\t{0}) Book title: {1, 35},\tAuthor: {2, 10},\t ISBN: {3}\n", ++count, book.Value.Name, book.Value.Author, book.Key);
      }

      return res.ToString();
    }
  }
}
