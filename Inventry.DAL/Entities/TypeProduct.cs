using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Inventry.DAL.Entities
{
  public class TypeProduct
  {
    [Key]
    public int ProductTypeId { get; set; }
    public string TypeName { get; set; }
    public virtual ICollection<ProductPurchase> Products { get; set; }
  }
}
