using GraphQL.EntityFramework;
using Northwind.DataLayer.Entities;
using Northwind.Server.Infrastructure.Graphs;

namespace Northwind.Server.Infrastructure
{
    public class Query : EfObjectGraphType
    {
        public Query(IEfGraphQLService efGraphQlService) : base(efGraphQlService)
        {
            AddQueryField<CategoryGraph, Category>(
                name: "categories",
                resolve: context =>
                {
                    var dataContext = (NorthwindContext)context.UserContext;
                    return dataContext.Categories;
                });

            AddSingleField<CategoryGraph, Category>(
                name: "category",
                resolve: context =>
                {
                    var dataContext = (NorthwindContext)context.UserContext;
                    return dataContext.Categories;
                });

            AddQueryConnectionField<CategoryGraph, Category>(
                name: "categoriesConnection",
                resolve: context =>
                {
                    var dataContext = (NorthwindContext)context.UserContext;
                    return dataContext.Categories;
                });

            AddQueryField<ProductGraph, Product>(
                name: "products",
                resolve: context =>
                {
                    var dataContext = (NorthwindContext)context.UserContext;
                    return dataContext.Products;
                });

            AddSingleField<ProductGraph, Product>(
                name: "product",
                resolve: context =>
                {
                    var dataContext = (NorthwindContext)context.UserContext;
                    return dataContext.Products;
                });

            AddQueryConnectionField<ProductGraph, Product>(
                name: "productsConnection",
                resolve: context =>
                {
                    var dataContext = (NorthwindContext)context.UserContext;
                    return dataContext.Products;
                });


            AddQueryField<SupplierGraph, Supplier>(
                name: "suppliers",
                resolve: context =>
                {
                    var dataContext = (NorthwindContext)context.UserContext;
                    return dataContext.Suppliers;
                });

            AddSingleField<SupplierGraph, Supplier>(
                name: "supplier",
                resolve: context =>
                {
                    var dataContext = (NorthwindContext)context.UserContext;
                    return dataContext.Suppliers;
                });

            AddQueryConnectionField<SupplierGraph, Supplier>(
                name: "suppliersConnection",
                resolve: context =>
                {
                    var dataContext = (NorthwindContext)context.UserContext;
                    return dataContext.Suppliers;
                });
        }
    }
}