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

    public override bool Equals(object book)
    {
      Book book1 = (Book)book;
      return (Name == book1.Name) && (Author == book1.Author) && (ISBN == book1.ISBN);
    }
  }
}
