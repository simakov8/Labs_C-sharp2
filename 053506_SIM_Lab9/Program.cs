using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053506_SIM_Lab9
{
  class Program
  {
    static void Main(string[] args)
    {
      Library library = new Library("Yakuba Kolasa");
      Library library1 = new Library("Yanki Kupala");
      Library library2 = new Library("Maksima Bogdanovicha");
      Library library3 = new Library("Maksima Tanka");
      Library library4 = new Library("Yanka Bril");

      Book book = new Book("It", "Stephen King", "1");
      library.AddBook(book);
      library1.AddBook(book);
      library3.AddBook(book);

      Book book1 = new Book("White Fang", "Jack London", "2");
      library1.AddBook(book1);
      library2.AddBook(book1);
      library4.AddBook(book1);

      Book book2 = new Book("Object-Oriented Programming in C++", "Robet Lafore", "3");
      library.AddBook(book2);
      library3.AddBook(book2);
      library4.AddBook(book2);
    }
  }
}
