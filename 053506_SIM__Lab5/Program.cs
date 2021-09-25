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

      shop.PurchaseMaked += (Person person, Product product) =>
      {
        Console.WriteLine(person.FirstName + " bought " + product.Name);
      };

      shop.AddProduct(new Product(100, 5, "gun"));
      shop.AddProduct(new Product(36, 8, "pizza"));
      shop.AddProduct(new Product(94, 8, "car"));
      shop.AddProduct(new Product(65, 8, "house"));
      Person vasya = new Person("Vasya", "Pupkin");
      Person petya = new Person("Petr", "Gubkin");
      shop.AddCustomer(vasya);
      vasya.ShowInfo();
      shop.MakePurchase(vasya, "car");
      shop.MakePurchase(vasya, "car");
      shop.MakePurchase(vasya, "gun");
      shop.MakePurchase(petya, "house");
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

      Console.WriteLine();

      shop.ShowProducts();

      Console.WriteLine();

      Console.WriteLine(shop.GetTotalPayment());

      Console.WriteLine();

      Console.WriteLine(shop.GetPersonsTotalPayment("Pupkin"));
      Console.WriteLine(shop.GetPersonsTotalPayment("Gubkin"));

      Console.WriteLine();

      Console.WriteLine(shop.GetCountRegularCustomers(193));

      Console.WriteLine();

      Console.WriteLine(shop.GetMaxPaymentName());

      dynamic evereProductPayments = shop.GetEveryProductPayments("Pupkin");
      foreach (var pr in evereProductPayments)
        Console.WriteLine("{0} - {1}", pr.productName, pr.totalPayment);
    }
  }
}
