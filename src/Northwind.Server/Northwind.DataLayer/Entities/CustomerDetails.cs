using System;
using System.Collections.Generic;

namespace Northwind.DataLayer.Entities
{
    public partial class CustomerDetails
    {
        public int Id { get; set; }
        public DateTime? LastContactDate { get; set; }
        public int? LastContactedBy { get; set; }
        public string Email { get; set; }
        public bool? SendBulletin { get; set; }

        public virtual Employee LastContactedByNavigation { get; set; }
    }
}
