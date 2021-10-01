using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "test";
      string description = "test";
      int price = 0;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_ReadsOrderTitle_String()
    {
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(title, newOrder.Title);
    }
    [TestMethod]
    public void OrderConstructor_ReadsOrderDescription_String()
    {
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(description, newOrder.Description);
    }
    [TestMethod]
    public void OrderConstructor_ReadsOrderPrice_Int()
    {
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(price, newOrder.Price);
    }
    [TestMethod]
    public void OrderConstructor_ReadsOrderDate_String()
    {
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(date, newOrder.Date);
    }
    // [TestMethod]
    // public void GetList_ReadsEmptyList_List()
    // {
    //   List<Order> emptyList = new List<Order>{};
    //   List<Order> testList = Order.GetList();
    //   CollectionAssert.AreEqual(emptyList,testList);
    // }
    // [TestMethod]
    // public void OrderConstructor_AutoAddsOrderToList_List()
    // {
    //   List<Order> emptyList = new List<Order>{};
    //   List<Order> testList = Order.GetList();
    //   CollectionAssert.AreEqual(emptyList,testList);
    // }
  }
}