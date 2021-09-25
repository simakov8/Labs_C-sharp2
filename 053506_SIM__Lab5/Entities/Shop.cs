using System;
using System.Collections.Generic;
using System.Linq;

namespace _053506_SIM__Lab1
{
  class Shop
  {
    public Shop()
    {
      m_products = new Dictionary<string, Product>();
      m_purchases = new List<(Person, Product)>();
      m_customers = new List<Person>();
    }
    private Dictionary<string, Product> m_products;
    private List<Person> m_customers;
    private List<(Person, Product)> m_purchases;

    public delegate void ProductAddedHandler(Product product);
    public event ProductAddedHandler ProductAdded;
    public void AddProduct(Product product)
    {
      m_products.Add(product.Name, product);
      ProductAdded?.Invoke(product);
    }

    public delegate void CustomerAddedHandler(Person customer);
    public event CustomerAddedHandler CustomerAdded;
    public void AddCustomer(Person customer)
    {
      m_customers.Add(customer);
      CustomerAdded?.Invoke(customer);
    }

    public delegate void PurchaseMakedHandler(Person person, Product product);
    public event PurchaseMakedHandler PurchaseMaked;
    public void MakePurchase(Person person, string productName)
    {
      Product product = null;
      foreach (var iterProduct in m_products)
      {
        if (iterProduct.Key == productName)
        {
          product = iterProduct.Value;
          continue;
        }
      }

      if (product == null)
        throw new Exception("Product not found");
      else
        m_purchases.Add((person, product));

      if (!m_customers.Contains(person))
        m_customers.Add(person);

      PurchaseMaked?.Invoke(person, product);
    }

    public void ShowInfoBySecondName(string sName)
    {
      int totalPrice = 0;
      int count = 0;
      for (int i = 0; i < m_purchases.Count; i++)
      {
        if (m_purchases[i].Item1.SecondName == sName)
        {
          totalPrice += m_purchases[i].Item2.Price;
          Console.WriteLine("{0}) product", ++count);
          m_purchases[i].Item2.ShowInfo();
        }
      }

      Console.WriteLine("Total price: {0}", totalPrice);
    }

    public void ShowProducts()
    {
      var produtsByPrice = from t in m_products
                           orderby t.Value.Price
                           select t.Key;

      foreach (var s in produtsByPrice)
        Console.WriteLine(s);
    }

    public int GetTotalPayment()
    {
      var totalPayment = (from p in m_purchases
                          select p.Item2.Price).Sum();

      return totalPayment;
    }

    public int GetPersonsTotalPayment(string secondName)
    {
      var totalPayment = (from p in m_purchases
                          where p.Item1.SecondName.Equals(secondName)
                          select p.Item2.Price).Sum();

      return totalPayment;
    }

    public string GetMaxPaymentName()
    {
      var maxPaymentName = (from p in m_purchases
                            group p.Item2.Price by p.Item1 into res1
                            select new { prsnName = res1.Key.FirstName, totalPayment = res1.Sum() })
                                 .OrderByDescending(i => i.totalPayment)
                                 .Select(i => i.prsnName)
                                 .First();

      return maxPaymentName;
    }

    public int GetCountRegularCustomers(int regularCustomerEdge)
    {
      var count = (from p in m_purchases
                   group p.Item2.Price by p.Item1 into res1
                   select res1.Sum()).Where(i => i > regularCustomerEdge).Select(i => i).Count();

      return count;
    }

    public object GetEveryProductPayments(string secondName)
    {
      var s = from p in m_purchases
              where p.Item1.SecondName.Equals(secondName)
              group p.Item2.Price by p.Item2.Name into res1
              select new { productName = res1.Key, totalPayment = res1.Sum() };
      
      return s;
    }
  }
}
