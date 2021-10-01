using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;
using System.Collections.Generic;

namespace PierresVendors.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/vendor/{vendorId}/order/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.FindVendor(vendorId);
      return View(vendor);
    }
  }
}