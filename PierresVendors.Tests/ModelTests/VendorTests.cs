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
      Vendor newVendor = new Vendor("Vendor", "Description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorConstructor_ReadsVendorName_String()
    {
      Vendor newVendor = new Vendor("Vendor", "Description");
      Assert.AreEqual("Vendor", newVendor.Name);
    }
    [TestMethod]
    public void VendorConstructor_ReadsVendorDescription_String()
    {
      Vendor newVendor = new Vendor("Vendor", "Description");
      Assert.AreEqual("Description", newVendor.Description);
    }
  }
}