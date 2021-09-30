using System;

namespace _053506_SIM__Lab1
{
  class Product
  {
    public Product(int price, int weight, string name)
    {
      Price = price;
      Weight = weight;
      Name = name;
    }
    public int Price { get; private set; }
    public int Weight { get; private set; }
    public string Name { get; private set; }
    public void ShowInfo()
    {
      Console.WriteLine("Name: {0}\nPrice: {1}\nWeight: {2}", Name, Price, Weight);
    }
  }
}
