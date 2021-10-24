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
  public class SellProductController : ControllerBase
  {
    private readonly IOnlineStore service;
    public SellProductController(IOnlineStore service)
    {
      this.service = service;
    }
    [HttpPost]
    public void Post(ProductsSellOrder sellproduct)
    {
      service.SellProductsFromInventory(sellproduct);
    }
  }
}
