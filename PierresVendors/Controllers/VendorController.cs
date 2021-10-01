using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresVendors.Models;

namespace PierresVendors.Controllers
{
  public class VendorController : Controller
  {

    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetList();
      return View(allVendors);
    }

    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendor")]
    public ActionResult Create(string name, string description)
    {
      Vendor newVendor= new Vendor(name, description);
      return RedirectToAction("Index");
    }
    
    [HttpGet("/vendor/{Id}")]
    public ActionResult Show(int Id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor findVendor= Vendor.FindVendor(Id);
      List<Order> vendorOrders = findVendor.Orders;
      model.Add("vendor", findVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendor/{vendorId}/order")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.FindVendor(vendorId);
      Order newOrder= new Order(orderTitle, orderDescription, orderPrice, orderDate);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrder = foundVendor.Orders;
      model.Add("orders", vendorOrder);
      model.Add("vendor", foundVendor);
      return View("Show", model);
    }

  }
}