using System.Collections.Generic;

namespace Inventry.Service.Models
{
    public class InventorySummary
    {
      public ICollection<ProductsPurchaseOrder> InventoryProducts { get; set; }
    }
}