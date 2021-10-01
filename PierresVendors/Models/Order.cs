using System;
using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public int Price {get; set;}
    public string Date {get; set;}
    public int Id {get;}
    private static int _instanceNumber = 0;
    private static List<Order> _instances = new List<Order> { };

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
      Id = _instanceNumber ++;
      _instances.Add(this);
    }

     public static List<Order> GetList()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
      _instanceNumber = 0;
    }
  }
}
