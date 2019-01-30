using GraphQL.EntityFramework;
using Northwind.DataLayer.Entities;

namespace Northwind.Server.Infrastructure.Graphs
{
    public class SupplierGraph : EfObjectGraphType<Supplier>
    {
        public SupplierGraph(IEfGraphQLService efGraphQlService) : base(efGraphQlService)
        {
            Field(x => x.SupplierId);
            
            Field(x => x.CompanyName);
            Field(x => x.ContactName);

            Field(x => x.ContactTitle);
            Field(x => x.Address);
            Field(x => x.Region);

            Field(x => x.PostalCode);
            Field(x => x.Country);

            Field(x => x.Phone);
            Field(x => x.Fax);
            Field(x => x.HomePage);
        }
    }
}