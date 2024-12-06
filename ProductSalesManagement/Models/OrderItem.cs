using System;
using System.Collections.Generic;

namespace ProductSalesManagement.Models;

public partial class OrderItem
{
    public int ItemId { get; set; }

    public int? Quantity { get; set; }

   // public decimal? ListPrice { get; set; }
    public decimal? Discount { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    [System.Text.Json.Serialization.JsonIgnore]
    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
