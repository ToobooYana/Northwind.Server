using System;
using System.Collections.Generic;

namespace Northwind.DataLayer.Entities
{
    public partial class CustomerCustomerDemo
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual CustomerDemographics CustomerType { get; set; }
    }
}
