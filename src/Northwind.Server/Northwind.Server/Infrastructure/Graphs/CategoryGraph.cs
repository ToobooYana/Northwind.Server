using GraphQL.EntityFramework;
using Northwind.DataLayer.Entities;

namespace Northwind.Server.Infrastructure.Graphs
{
    public class CategoryGraph : EfObjectGraphType<Category>
    {
        public CategoryGraph(IEfGraphQLService efGraphQlService) : base(efGraphQlService)
        {
            Name = "Category";

            Field(x => x.Id);
            Field(x => x.CategoryName);
            Field(x => x.Description);
            //Field(x => x.Picture);

            AddNavigationField<ProductGraph, Product>(
                name: "products",
                resolve: context => context.Source.Products);
        }
    }
}