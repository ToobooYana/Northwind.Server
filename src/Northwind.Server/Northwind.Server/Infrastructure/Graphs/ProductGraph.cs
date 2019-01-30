using GraphQL.EntityFramework;
using Northwind.DataLayer.Entities;

namespace Northwind.Server.Infrastructure.Graphs
{
    public class ProductGraph : EfObjectGraphType<Product>
    {
        public ProductGraph(IEfGraphQLService efGraphQlService) : base(efGraphQlService)
        {
            Field(x => x.ProductId);
            Field(x => x.ProductName);
            Field(x => x.ProductImage);
            Field(x => x.Discontinued);

            //Field(x => x.Supplier);
            //Field(x => x.Category);

            Field(x => x.QuantityPerUnit);
            Field(x => x.UnitPrice);

            Field(x => x.UnitsInStock);
            Field(x => x.UnitsOnOrder);
            Field(x => x.ReorderLevel);

            //AddNavigationField<CategoryGraph, Category>(
            //    name: "category",
            //    resolve: context => context.Source.Category);

            //AddNavigationField<SupplierGraph, Supplier>(
            //    name: "supplier",
            //    resolve: context => context.Source.Supplier);
        }
    }
}