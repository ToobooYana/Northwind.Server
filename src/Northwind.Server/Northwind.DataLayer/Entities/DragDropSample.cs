using System;
using System.Collections.Generic;

namespace Northwind.DataLayer.Entities
{
    public partial class DragDropSample
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Title { get; set; }
    }
}
