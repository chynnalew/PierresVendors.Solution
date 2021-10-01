using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests :IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

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
    [TestMethod]
    public void GetList_ReadsEmptyList_List()
    {
      List<Order> emptyList = new List<Order>{};
      List<Order> testList = Order.GetList();
      CollectionAssert.AreEqual(emptyList,testList);
    }
    [TestMethod]
    public void OrderConstructor_AutoAddsOrderToList_List()
    {
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList = new List<Order>{};
      List<Order> testList = Order.GetList();
      newList.Add(newOrder);
      CollectionAssert.AreEqual(newList,testList);
    }
    [TestMethod]
    public void ClearAll_ClearsThePrivateList_True()
    {
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      Order.ClearAll();
      List<Order> testList = Order.GetList();
      List<Order> emptyList = new List<Order> {};
      CollectionAssert.AreEqual(emptyList, testList);
    }
    [TestMethod]
    public void OrderConstructor_ConstructorAssignsUniqueId_Int()
    {      
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(0, newOrder.Id);
    }
    [TestMethod]
    public void OrderConstructor_ConstructorAssignsUniqueIds_Int()
    {      
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      string title2 = "title";
      string description2 = "description";
      int price2 = 10;
      string date2 = "date";
      Order newOrder2 = new Order(title2, description2, price2, date2);
      Assert.AreEqual(1, newOrder2.Id);
    }
    [TestMethod]
    public void FindOrder_FindsOrderById_Order()
    {      
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      List<Order> testList = Order.GetList();
      Assert.AreEqual(Order.FindOrder(0), testList[0]);
    }
    [TestMethod]
    public void DeleteOrder_DeleteASingleOrder_List()
    {      
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      Order newOrder2 = new Order(title, description, price, date);
      List<Order> testList = Order.GetList();
      List<Order> list2 = new List<Order>{};
      list2.Add(newOrder2);
      Order.DeleteOrder(0);
      CollectionAssert.AreEqual(testList, list2);
    }
  }
}