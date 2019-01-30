using System.Collections.Generic;
using FluentAssertions;
using Northwind.Server.Infrastructure.Extensions;
using NUnit.Framework;

namespace Northwind.Server.Test
{
    [TestFixture]
    public class TestForMutationExtensions
    {
        private Dummy _testContext;

        public class Dummy
        {
            public string Name { get; set; }

            public int Id { get; set; }

            public string Description { get; set; } 
        }

        public class Other
        {
            public string Description { get; set; }
        }

        [SetUp]
        public void Initialize_Testcontext()
        {

            var propertiesForTestContext = new Dictionary<string, object>
            {
                {nameof(Dummy.Description), "a new description"},
            };

            var propertiesForOther = new Dictionary<string, object>
            {
                {nameof(Other.Description), "don't use this one"},
            };

            var arguments = new Dictionary<string, object>
            {
                { "other", propertiesForOther },
                { "dummy", propertiesForTestContext },
            };

            _testContext = new Dummy { Id = 10, Name = "#10", Description = "older one" };
            var updated = new Dummy { Id = 10, Description = propertiesForTestContext[nameof(Dummy.Description)].ToString() };

            _testContext.UpdateFrom(updated, arguments, "dummy");
        }

        [Test]
        public void Should_update_Description()
        {
            _testContext.Description.Should().Be("a new description");
        }

        [Test]
        public void Should_not_update_Name()
        {
            _testContext.Name.Should().Be("#10");
        }
    }
}