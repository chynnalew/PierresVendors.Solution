using System;
using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public string Description {get; set;}
    public List<Order> Orders {get; set;}
    public int Id {get;}
    private static int _instanceNumber = 0;
    private static List<Vendor> _instance = new List<Vendor> {};

    public Vendor (string name, string description)
    {
      Name = name;
      Description = description;
      Orders = new List<Order> {};
      Id = _instanceNumber ++;
      _instance.Add(this);
    }

    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }

    public static List<Vendor> GetList()
    {
      return _instance;
    }

    public static void ClearAll()
    {
      _instance.Clear();
      _instanceNumber = 0;
    }

    public static Vendor FindVendor(int ID)
    {
      return _instance.Find(vendor => vendor.Id ==ID);
    }
  }
}