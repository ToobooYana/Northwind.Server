using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Northwind.Server.Infrastructure.Extensions
{
    public static class MutationExtensions
    {
        public static void UpdateFrom(this object target, object source, Dictionary<string, object> arguments,
            string queryArgumentName)
        {
            var expectedKeyName = queryArgumentName.ToLower();
            var dictionary = arguments.FirstOrDefault(a => a.Key.ToLower().Equals(expectedKeyName)).Value as Dictionary<string, object>;

            if (dictionary == null) return;

            var sourcePropertyNames = dictionary.Keys.Select(k => k.ToLower()).ToList();

            foreach (var propertyName in target.GetPropertyNames())
            {
                if (sourcePropertyNames.Contains(propertyName.ToLower()))
                {
                    target.UpdatePropertyFrom(source, propertyName);
                }
            }
        }

        private static void UpdatePropertyFrom(this object target, object source, string propertyName)
        {
            var property = source.GetType().GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Public);
            if (property == null)
                return;
            var value = property.GetValue(source, (object[])null);

            property.SetValue(target, value);
        }

        private static IEnumerable<string> GetPropertyNames(this object o)
        {
            return o.GetType().GetProperties().Select(s => s.Name);
        }
    }
}