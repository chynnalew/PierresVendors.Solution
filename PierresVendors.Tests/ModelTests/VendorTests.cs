using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresVendors.Models;

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
  }
}