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

    public Order(string title, string description)
    {
      Title = title;
      Description = description;
    }
  }
}