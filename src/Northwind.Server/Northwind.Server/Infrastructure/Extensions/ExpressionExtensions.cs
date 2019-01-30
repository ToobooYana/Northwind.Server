using System;
using System.Linq.Expressions;

namespace Northwind.Server.Infrastructure.Extensions
{
    public static class ExpressionExtensions
    {
        public static string NameOf<T, P>(this Expression<Func<T, P>> expression)
        {
            return ((MemberExpression)expression.Body).Member.Name;
        }
    }
}