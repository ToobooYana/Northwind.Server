using EfCore.InMemoryHelpers;
using Northwind.DataLayer.Entities;

// InMemory is used to make the sample simpler.
// Replace with a real DataContext
public static class DataContextBuilder
{
    public static NorthwindContext BuildDataContext()
    {
        var category = new Category { };
        var myDataContext = InMemoryContextBuilder.Build<NorthwindContext>();
        myDataContext.AddRange(category);
        myDataContext.SaveChanges();
        return myDataContext;
    }
}
