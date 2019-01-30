using GraphQL.Types;
using Northwind.DataLayer.Entities;
using Northwind.Server.Infrastructure.Extensions;

namespace Northwind.Server.Infrastructure.Strategies
{
    public class MutationStrategy<TEntity> : IMutationStrategy<TEntity> where TEntity : class
    {
        public TEntity Execute(ResolveFieldContext<object> context, NorthwindContext ctx, string queryArgumentName)
        {
            TEntity Find(int id) => ctx.Set<TEntity>().Find(id);

            var category = context.GetArgument<Category>(queryArgumentName);

            var persisted = Find(category.Id);
            persisted.UpdateFrom(category, context.Arguments, queryArgumentName);
            ctx.SaveChanges();

            var result = Find(category.Id);
            return result;
        }
    }
}