using Microsoft.EntityFrameworkCore;
using Northwind.DataLayer.Entities;
using Northwind.DataLayer.Infrastructure;

namespace Northwind.DataLayer
{
    public class NorthwindDbContextFactory : DesignTimeDbContextFactoryBase<NorthwindContext>
    {
        protected override NorthwindContext CreateNewInstance(DbContextOptions<NorthwindContext> options)
        {
            return new NorthwindContext(options);
        }
    }
}