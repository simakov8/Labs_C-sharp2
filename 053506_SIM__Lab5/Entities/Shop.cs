using System;
using System.Collections.Generic;

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

    public delegate void PurchaseMakedHandler(Person person, string productName);
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
      PurchaseMaked?.Invoke(person, product.Name);
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
  }
}
