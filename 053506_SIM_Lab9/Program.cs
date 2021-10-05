using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _053506_SIM_Lab9
{
  class Program
  {
    static void Main(string[] args)
    {
      Library[] libraries =
      {
        new Library("Yakuba Kolasa"),
        new Library("Yanki Kupala"),
        new Library("Maksima Bogdanovicha"),
        new Library("Maksima Tanka"),
        new Library("Yanka Bril")
      };

      Book book = new Book("It", "Stephen King", "1");
      libraries[0].AddBook(book);
      libraries[1].AddBook(book);
      libraries[3].AddBook(book);

      Book book1 = new Book("White Fang", "Jack London", "2");
      libraries[1].AddBook(book1);
      libraries[2].AddBook(book1);
      libraries[4].AddBook(book1);

      Book book2 = new Book("Object-Oriented Programming in C++", "Robet Lafore", "3");
      libraries[0].AddBook(book2);
      libraries[3].AddBook(book2);
      libraries[4].AddBook(book2);  

      Serializer serializer = new Serializer();

      // Serialize by LINQ
      serializer.SerializeByLINQ(libraries, "libraries.xml");
      Library[] librariesByLINQ = serializer.DeSerializeByLINQ("libraries.xml").ToArray();
      Console.WriteLine(libraries.SequenceEqual(librariesByLINQ));

      // Serialize XML
      serializer.SerializeXML(libraries, "libraries1.xml");
      Library[] librariesXML = serializer.DeSerializeXML("libraries1.xml").ToArray();
      Console.WriteLine(libraries.SequenceEqual(librariesXML));
    }
  }
}
