using System;

namespace _053506_SIM__Lab1
{
  class Program
  {
    static void Main(string[] args)
    {
      Shop shop = new Shop();
      Jornal jornal = new Jornal();

      shop.ProductAdded += jornal.NewProductHandler;
      shop.CustomerAdded += jornal.NewCustomerHandler;

      shop.AddProduct(new Product(10, 5, "gun"));
      shop.AddProduct(new Product(36, 8, "pizza"));
      shop.AddProduct(new Product(94, 8, "car"));
      shop.AddProduct(new Product(65, 8, "house"));
      Person vasya = new Person("Vasya", "Pupkin");
      shop.AddCustomer(vasya);
      vasya.ShowInfo();
      shop.MakePurchase(vasya, "car");
      shop.MakePurchase(vasya, "gun");
      try
      {
        shop.MakePurchase(vasya, "galaxy");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
      shop.ShowInfoBySecondName("Pupkin");

      jornal.ShowLog();
    }
  }
}
