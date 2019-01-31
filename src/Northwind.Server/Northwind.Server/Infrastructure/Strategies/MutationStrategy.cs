using System;
using GraphQL.Types;
using Northwind.DataLayer.Entities;
using Northwind.Server.Infrastructure.Extensions;

namespace Northwind.Server.Infrastructure.Strategies
{
    public class MutationStrategy<TEntity> : IMutationStrategy<TEntity> where TEntity : class
    {
        public TEntity Execute(ResolveFieldContext<object> context, NorthwindContext ctx, 
            Func<TEntity, object> resolveKeyValue, string queryArgumentName)
        {
            TEntity Find(object keyValue) => ctx.Set<TEntity>().Find(keyValue);

            var entity = context.GetArgument<TEntity>(queryArgumentName);

            var key = resolveKeyValue(entity);
            var persisted = Find(key);
            persisted.UpdateFrom(entity, context.Arguments, queryArgumentName);
            ctx.SaveChanges();

            var result = Find(key);
            return result;
        }
    }
}