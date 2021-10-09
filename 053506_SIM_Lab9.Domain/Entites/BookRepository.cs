using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _053506_SIM_Lab9
{
  [JsonObject]
  public class BookRepository : IEnumerable<Book>
  {
    public BookRepository()
    {
      Books = new List<Book>();
    }

    public List<Book> Books { get; set; }

    public void Add(Book book)
    {
      Books.Add(book);
    }

    public bool Equals(BookRepository books)
    {
      return Books.SequenceEqual(books.Books);
    }

    public IEnumerator<Book> GetEnumerator()
    {
      return Books.GetEnumerator();
      //foreach (var book in Books)
      //    yield return book;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return Books.GetEnumerator();
      //foreach (var book in Books)
      //  yield return book;
    }
  }
}
