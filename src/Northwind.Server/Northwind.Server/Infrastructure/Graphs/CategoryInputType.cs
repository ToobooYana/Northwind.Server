using System.Security.Cryptography.X509Certificates;
using GraphQL.Types;
using Northwind.DataLayer.Entities;

namespace Northwind.Server.Infrastructure.Graphs
{
    public class CategoryInputType : InputObjectGraphType<Category>
    {
        public CategoryInputType()
        {
            Name = "CategoryInput";
            Field(x => x.CategoryName);
            Field(x => x.Description, nullable: true);
        }
    }

    public class CategoryUpdateInputType : InputObjectGraphType<Category>
    {
        public CategoryUpdateInputType()
        {
            Name = "CategoryUpdateInput";
            
            Field(x => x.Id);
            Field(x => x.CategoryName, nullable: true);
            Field(x => x.Description, nullable: true);
        }
    }

}