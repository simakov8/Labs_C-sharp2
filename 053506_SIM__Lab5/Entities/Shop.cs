using System;


namespace _053506_SIM__Lab1
{
  class Shop
  {
    public Shop()
    {
      products = new MyCustomCollection<Product>();
      purchases = new MyCustomCollection<(Person, Product)>();
    }
    private MyCustomCollection<Product> products;
    private MyCustomCollection<(Person, Product)> purchases;

    public void AddProduct(Product product)
    {
      products.Add(product);
    }

    public void MakePurchase(Person person, string productName)
    {
      Product product = null;
      for (int i = 0; i < products.Count; i++)
      {
        if (products[i].Name == productName)
        {
          product = products[i];
          continue;
        }
      }
      if (product == null)
        throw new Exception("Product not found");
      else
        purchases.Add((person, product));
    }

    public void ShowInfoBySecondName(string sName)
    {
      int totalPrice = 0;
      int count = 0;
      for (int i = 0; i < purchases.Count; i++)
      {
        if (purchases[i].Item1.SecondName == sName)
        {
          totalPrice += purchases[i].Item2.Price;
          Console.WriteLine("{0}) product", ++count);
          purchases[i].Item2.ShowInfo();
        }
      }

      Console.WriteLine("Total price: {0}", totalPrice);
    }
  }
}
