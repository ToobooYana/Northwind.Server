using System;
using System.Collections.Generic;

namespace Northwind.DataLayer.Entities
{
    public partial class ProductLang
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int LanguageId { get; set; }
        public string ProductName { get; set; }
    }
}
