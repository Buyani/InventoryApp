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
  public class ProductTypeController : ControllerBase
  {
    private readonly IOnlineStore service;
    public ProductTypeController(IOnlineStore service)
    {
      this.service = service;
    }
    // GET: api/<ProductTypeController>
    [HttpGet]
    public IEnumerable<ProductType> Get()
    {
      return service.GetAllProductTypes();
    }

    // GET api/<ProductTypeController>/5
    [HttpGet("{id}")]
    public ProductType Get(int id)
    {
      return service.GetProductTypeById(id);
    }

    // POST api/<ProductTypeController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<ProductTypeController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<ProductTypeController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
