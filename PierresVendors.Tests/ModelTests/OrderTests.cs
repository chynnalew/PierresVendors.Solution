using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;

namespace PierresVendors.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test", "test", 0);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_ReadsOrderTitle_String()
    {
      Order newOrder = new Order("title", "description", 0);
      Assert.AreEqual("title", newOrder.Title);
    }
    [TestMethod]
    public void OrderConstructor_ReadsOrderDescription_String()
    {
      Order newOrder = new Order("title", "description", 0);
      Assert.AreEqual("description", newOrder.Description);
    }
    [TestMethod]
    public void OrderConstructor_ReadsOrderDescription_Int()
    {
      Order newOrder = new Order("title", "description", 10);
      Assert.AreEqual(10, newOrder.Price);
    }
  }
}