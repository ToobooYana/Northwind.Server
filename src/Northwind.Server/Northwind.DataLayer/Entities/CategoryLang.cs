using System;
using System.Collections.Generic;

namespace Northwind.DataLayer.Entities
{
    public partial class CategoryLang
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int LanguageId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
