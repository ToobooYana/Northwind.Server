using System;
using System.Linq.Expressions;
using FluentAssertions;
using Northwind.Server.Infrastructure.Extensions;
using NUnit.Framework;

namespace Northwind.Server.Test
{
    [TestFixture]
    public class TestForExpressionExtensions
    {
        class Dummy
        {
            public int Id { get; set; }
        }

        [Test]
        public void Should_get_property_name()
        {
            var dummy = new Dummy();
            var name = Name<Dummy, int>(d => dummy.Id);

            name.Should().Be("Id");
        }

        private string Name<TSourceType, TProperty>(Expression<Func<TSourceType, TProperty>> expression)
        {
            return expression.NameOf();
        }
    }
}
