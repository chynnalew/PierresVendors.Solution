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

    [HttpPost("/vendor/{vendorId}/order/{orderId}")]
    public ActionResult Create(string title, string description, int price, string date)
    {
      Order newOrder= new Order(title, description, price, date);
      return RedirectToAction("Show");
    }

    [HttpGet("/vendor/{vendorId}/order/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Order order = Order.FindOrder(orderId);
      Vendor vendor = Vendor.FindVendor(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
  }
}