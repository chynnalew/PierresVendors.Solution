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
      Vendor selectedVendor = Vendor.FindVendor(Id);
      return View(selectedVendor);
    }
  }
}