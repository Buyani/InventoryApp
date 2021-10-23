using AutoMapper;
using Inventry.DAL.Entities;
using Inventry.Service.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inventry.Service
{
  public class AutoMapp:Profile
  {
    public AutoMapp()
    {

      CreateMap<ProductPurchase, ProductsPurchaseOrder>();
      CreateMap<ProductsPurchaseOrder, ProductPurchase>();

      CreateMap<ProductSold, ProductsSellOrder>();
      CreateMap<ProductsSellOrder, ProductSold>();

      CreateMap<ProductPurchase, InventorySummary>();

      CreateMap<ProductType, TypeProduct>();
      CreateMap<TypeProduct, ProductType>();

    }
  }
}
