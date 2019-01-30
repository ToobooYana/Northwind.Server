using System;
using System.Collections.Generic;
using GraphQL;
using GraphQL.Types;
using Northwind.DataLayer.Entities;
using Northwind.Server.Infrastructure.Graphs;
using Northwind.Server.Infrastructure.Strategies;

namespace Northwind.Server.Infrastructure
{
    public class Mutation : ObjectGraphType
    {
        public Mutation(NorthwindContext ctx, IDependencyResolver resolver)
        {
            Name = "Mutation";

            Field<CategoryGraph>(
                "createCategory",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CategoryInputType>> { Name = "category" }
                ),
                resolve: context =>
                {
                    var category = context.GetArgument<Category>("category");
                    ctx.Categories.Add(category);
                    ctx.SaveChanges();
                    return category;
                });

            Field<CategoryGraph>(
                "updateCategory",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CategoryUpdateInputType>> { Name = "category" }
                ),
                resolve: context => resolver
                    .Resolve<IMutationStrategy<Category>>()
                    .Execute(context, ctx, "category"));
        }
    }
}