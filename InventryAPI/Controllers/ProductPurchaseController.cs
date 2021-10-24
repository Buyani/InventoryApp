using Inventry.Service;
using Inventry.Service.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InventryAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductPurchaseController : ControllerBase
  {
    private readonly IOnlineStore service;
    public ProductPurchaseController(IOnlineStore service)
    {
      this.service = service;
    }
    // GET: api/<ProductPurchaseController>
    [HttpGet]
    public IEnumerable<ProductsPurchaseOrder> Get()
    {
      var list = new List<ProductsPurchaseOrder>();

      foreach(var product in service.GetInventorySummary().InventoryProducts)
      {
        list.Add(product);
      }
      return list;
    }
    [HttpPost]
    public void Post(ProductsPurchaseOrder products)
    {
      service.AddProductsToInventory(products);
    }

  }
}

