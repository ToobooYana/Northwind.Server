using System;
using GraphQL.Types;
using Northwind.DataLayer.Entities;

namespace Northwind.Server.Infrastructure.Strategies
{
    public interface IMutationStrategy<out TEntity> where TEntity: class
    {
        TEntity Execute(ResolveFieldContext<object> context, NorthwindContext ctx, 
            Func<TEntity, object> resolveKeyValue, string queryArgumentName);
    }
}