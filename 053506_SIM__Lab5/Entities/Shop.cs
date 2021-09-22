using System;


namespace _053506_SIM__Lab1
{
  class Shop
  {
    public Shop()
    {
      m_products = new MyCustomCollection<Product>();
      m_purchases = new MyCustomCollection<(Person, Product)>();
      m_customers = new MyCustomCollection<Person>();
    }
    private MyCustomCollection<Product> m_products;
    private MyCustomCollection<Person> m_customers;
    private MyCustomCollection<(Person, Product)> m_purchases;

    public delegate void ProductAddedHandler(Product product);
    public event ProductAddedHandler ProductAdded;
    public void AddProduct(Product product)
    {
      m_products.Add(product);
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
      for (int i = 0; i < m_products.Count; i++)
      {
        if (m_products[i].Name == productName)
        {
          product = m_products[i];
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
