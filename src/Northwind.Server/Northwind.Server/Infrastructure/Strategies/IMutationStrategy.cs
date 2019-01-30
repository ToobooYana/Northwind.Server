using GraphQL.Types;
using Northwind.DataLayer.Entities;

namespace Northwind.Server.Infrastructure.Strategies
{
    public interface IMutationStrategy<TEntity> where TEntity: class
    {
        TEntity Execute(ResolveFieldContext<object> context, NorthwindContext ctx, string queryArgumentName);
    }
}