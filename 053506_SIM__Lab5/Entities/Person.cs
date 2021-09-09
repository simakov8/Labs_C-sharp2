namespace _053506_SIM__Lab1
{
  class Person
  {
    public Person(string fName, string sName)
    {
      FirstName = fName;
      SecondName = sName;
    }
    public string FirstName { get; private set; }
    public string SecondName { get; private set; }
  }
}
