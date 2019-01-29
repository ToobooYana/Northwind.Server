using System;
using System.Collections.Generic;

namespace Northwind.DataLayer.Entities
{
    public partial class ProductLog
    {
        public long ProductLogId { get; set; }
        public short OperationType { get; set; }
        public int? ChangingUserId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidUntil { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public bool? Discontinued { get; set; }
        public int? SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
    }
}
