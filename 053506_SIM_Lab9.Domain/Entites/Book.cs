using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053506_SIM_Lab9
{
  public class Book
  {
    public Book() { }
    public Book(string name, string author, string isbn)
    {
      Name = name;
      Author = author;
      ISBN = isbn;
    }

    public string Name { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public bool Equals(Book book)
    {
      return (Name == book.Name) && (Author == book.Author) && (ISBN == book.ISBN);
    }
  }
}
