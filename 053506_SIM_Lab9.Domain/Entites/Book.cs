using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053506_SIM_Lab9
{
  public class Book
  {
    public Book(string name, string author, string isbn)
    {
      Name = name;
      Author = author;
      ISBN = isbn;
    }

    public string Name { get; private set; }
    public string Author { get; private set; }
    public string ISBN { get; private set; }
  }
}
