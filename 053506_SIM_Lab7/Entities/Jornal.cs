using System;
using System.Text;

namespace _053506_SIM__Lab1
{
  class Jornal
  {
    public Jornal()
    {
      m_eventLog = new MyCustomCollection<StringBuilder>();
      m_nCountLog = 0;
    }
    private static int m_nCountLog;

    private MyCustomCollection<StringBuilder> m_eventLog;

    public void NewProductHandler(Product product)
    {
      StringBuilder logRecord = new StringBuilder();
      logRecord.Append((++m_nCountLog).ToString() + ") ");
      logRecord.Append(DateTime.Now.ToString() + ": ");
      logRecord.Append(String.Format("New product\n\t\t\tName: {0}\n\t\t\tWeight: {1}\n\t\t\tPrice: {2}", product.Name, product.Weight, product.Price));
      m_eventLog.Add(logRecord);
    }
    public void NewCustomerHandler(Person customer)
    {
      StringBuilder logRecord = new StringBuilder();
      logRecord.Append((++m_nCountLog).ToString() + ") ");
      logRecord.Append(DateTime.Now.ToString() + ": ");
      logRecord.Append(String.Format("New customer\n\t\t\tFirst name: {0}\n\t\t\tSecond name: {1}", customer.FirstName, customer.SecondName));
      m_eventLog.Add(logRecord);
    }

    public void ShowLog()
    {
      for (int i = 0; i < m_nCountLog; ++i)
      {
        Console.WriteLine(m_eventLog[i]);
      }
    }
  }
}
