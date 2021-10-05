using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace _053506_SIM_Lab9
{
  public class Serializer : ISerializer
  {
    public IEnumerable<Library> DeSerializeByLINQ(string fileName)
    {
      XDocument xdoc = XDocument.Load(fileName);

      foreach (var libraryElement in xdoc.Element("Libraries").Elements("Library"))
      {
        XAttribute nameAttribute = libraryElement.Attribute("Name");
        Library library = new Library(nameAttribute.Value);

        foreach (var bookElement in libraryElement.Elements("Book"))
        {
          XAttribute bookName = bookElement.Attribute("Name");
          XAttribute bookAuthor = bookElement.Attribute("Author");
          XAttribute bookIsbn = bookElement.Attribute("ISBN");
          library.AddBook(new Book(bookName.Value, bookAuthor.Value, bookIsbn.Value));
        }

        yield return library;
      }
    }

    public IEnumerable<Library> DeSerializeJSON(string fileName)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<Library> DeSerializeXML(string fileName)
    {
      throw new NotImplementedException();
    }

    public void SerializeByLINQ(IEnumerable<Library> libraries, string fileName)
    {
      XDocument xdoc = new XDocument();
      XElement xElement = new XElement("Libraries");

      foreach (var library in libraries)
      {
        XElement lib = new XElement("Library");
        lib.Add(new XAttribute("Name", library.Name));

        foreach (var book in library.BookRepository)
        {
          XElement bookElement = new XElement("Book");
          bookElement.Add(new XAttribute("Name", book.Name));
          bookElement.Add(new XAttribute("Author", book.Author));
          bookElement.Add(new XAttribute("ISBN", book.ISBN));
          lib.Add(bookElement);
        }

        xElement.Add(lib);
      }
      xdoc.Add(xElement);
      xdoc.Save(fileName);
    }

    public void SerializeJSON(IEnumerable<Library> libraries, string fileName)
    {
      throw new NotImplementedException();
    }

    public void SerializeXML(IEnumerable<Library> libraries, string fileName)
    {
      throw new NotImplementedException();
    }
  }
}
