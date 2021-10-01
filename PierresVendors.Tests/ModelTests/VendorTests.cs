using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;
using System;
using System.Collections.Generic;

namespace PierresVendors.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      string name = "Vendor";
      string description = "Description";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorConstructor_ReadsVendorName_String()
    {
      string name = "Vendor";
      string description = "Description";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(name, newVendor.Name);
    }
    [TestMethod]
    public void VendorConstructor_ReadsVendorDescription_String()
    {
      string name = "Vendor";
      string description = "Description";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(description, newVendor.Description);
    }
    [TestMethod]
    public void AddOrder_AddsOrderToVendorList_List()
    {
      string title = "title";
      string description = "description";
      int price = 10;
      string date = "date";
      Order newOrder = new Order(title, description, price, date);
      List<Order> newList = new List<Order> { newOrder };
      string name = "name";
      string description2 = "test";
      Vendor newVendor = new Vendor(name, description2);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void VendorConstructor_ConstructorAssignsUniqueId_Int()
    {      
      string name = "Vendor";
      string description = "Description";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(4, newVendor.Id);
    }
    [TestMethod]
    public void VendorConstructor_ConstructorAssignsUniqueIds_Int()
    {      
      string name = "Vendor";
      string description = "Description";
      Vendor newVendor = new Vendor(name, description);
      string name2 = "Vendor2";
      string description2 = "Description2";
      Vendor newVendor2 = new Vendor(name2, description2);
      Assert.AreEqual(6, newVendor2.Id);
    }
  }
}