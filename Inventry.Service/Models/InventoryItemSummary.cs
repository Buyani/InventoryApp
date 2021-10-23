using System.Collections.Generic;

namespace Inventry.Service.Models
{
  public class InventoryItemSummary
  {
    public ICollection<ProductsPurchaseOrder> InventoryProducts { get; set; }
    public decimal AveragePrice { get; set; }
  }
}