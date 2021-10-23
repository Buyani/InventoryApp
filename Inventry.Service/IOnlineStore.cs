using Inventry.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventry.Service
{
  public interface IOnlineStore
  {
    void AddProductsToInventory(ProductsPurchaseOrder purchaseOrder);
    ProductsSoldResults SellProductsFromInventory(ProductsSellOrder itemsSoldOrder);
    InventoryItemSummary GetInventoryItemSummary(ProductType stockType);
    InventorySummary GetInventorySummary();
    List<ProductType> GetAllProductTypes();
    ProductType GetProductTypeById(int Id);
  }
}
