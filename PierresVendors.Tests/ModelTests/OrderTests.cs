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
      Order newOrder = new Order("test", "test", 0, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_ReadsOrderTitle_String()
    {
      Order newOrder = new Order("title", "description", 0, "date");
      Assert.AreEqual("title", newOrder.Title);
    }
    [TestMethod]
    public void OrderConstructor_ReadsOrderDescription_String()
    {
      Order newOrder = new Order("title", "description", 0, "date");
      Assert.AreEqual("description", newOrder.Description);
    }
    [TestMethod]
    public void OrderConstructor_ReadsOrderPrice_Int()
    {
      Order newOrder = new Order("title", "description", 10, "date");
      Assert.AreEqual(10, newOrder.Price);
    }
    [TestMethod]
    public void OrderConstructor_ReadsOrderDate_String()
    {
      Order newOrder = new Order("title", "description", 10, "10-25-2021");
      Assert.AreEqual("10-25-2021", newOrder.Date);
    }
    [TestMethod]
    public void GetList_ReadsEmptyList_List()
    {
      List<Order> emptyList = new List<Order>{};
      List<Order> testList = Order.GetList();
      CollectionAssert.AreEqual(emptyList,testList);
    }
  }
}