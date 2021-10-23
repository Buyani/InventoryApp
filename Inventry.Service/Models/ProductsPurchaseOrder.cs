﻿namespace Inventry.Service.Models
{
  public class ProductsPurchaseOrder
  {
    public int ProductPurchaseId { get; set; }
    public int Quantity { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public int ProductTypeId { get; set; }
  }
}