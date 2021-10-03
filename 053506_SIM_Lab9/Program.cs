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

      Reader reader = new Reader("Ivan");
      library.AddReader(reader);

      Reader reader1 = new Reader("Petr");
      library1.AddReader(reader1);

      Reader reader2 = new Reader("Gena");
      library2.AddReader(reader2);

      Reader reader3 = new Reader("Vasya");
      library3.AddReader(reader3);

      Reader reader4 = new Reader("Arcadiy");
      library4.AddReader(reader4);

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

      library.MakeOrder("Ivan", "1");
      library1.MakeOrder("Petr", "1");
      library2.MakeOrder("Gena", "2");
      library3.MakeOrder("Vasya", "3");
      library4.MakeOrder("Arcadiy", "2");

      Console.WriteLine(library.GetInfo());
      Console.WriteLine(library1.GetInfo());
      Console.WriteLine(library2.GetInfo());
      Console.WriteLine(library3.GetInfo());
      Console.WriteLine(library4.GetInfo());
    }
  }
}
