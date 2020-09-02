namespace Landorphan.BuildMap.Serialization.Formatters.Implementation
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using Landorphan.BuildMap.Model;
    using Landorphan.BuildMap.Model.Support;
    using Landorphan.BuildMap.Serialization.Attributes;
    using Landorphan.BuildMap.Serialization.Formatters.Interfaces;
    using Landorphan.Common;
    using Newtonsoft.Json;

    public class TextFormatter : IFormatWriter
    {
        public TextFormatter() : this(null)
        {
        }

        public TextFormatter(IEnumerable<string> itemHints)
        {
            Items = GetDefaultItems();
            if (itemHints != null &&
                itemHints.Any())
            {
                Items = itemHints;
            }
        }

        public IEnumerable<string> Items { get; private set; }

        public string Write(Map map)
        {
            map.ArgumentNotNull(nameof(map));

            var builder = new StringBuilder();

            var build = map.Build;
            var mapProperties = new Dictionary<string, PropertyInfo>(
                from p in typeof(Map).GetProperties()
                where p.PropertyType != typeof(Build)
                select new KeyValuePair<string, PropertyInfo>(p.Name, p));
            var buildProperties = new Dictionary<string, PropertyInfo>(
                from p in typeof(Build).GetProperties()
                where p.PropertyType != typeof(ProjectList)
                select new KeyValuePair<string, PropertyInfo>(p.Name, p));
            var projectProperties = new Dictionary<string, PropertyInfo>(
                from p in typeof(Project).GetProperties()
                select new KeyValuePair<string, PropertyInfo>(p.Name, p));

            foreach (var project in map.Build.Projects)
            {
                var count = 0;
                foreach (var item in Items)
                {
                    PropertyInfo property = null;
                    if (projectProperties.TryGetValue(item, out property))
                    {
                        if (count++ > 0)
                        {
                            builder.Append("\t");
                        }

                        builder.Append(property.GetValue(project));
                    }
                    else if (buildProperties.TryGetValue(item, out property))
                    {
                        if (count++ > 0)
                        {
                            builder.Append("\t");
                        }

                        builder.Append(property.GetValue(build));
                    }
                    else if (mapProperties.TryGetValue(item, out property))
                    {
                        if (count++ > 0)
                        {
                            builder.Append("\t");
                        }

                        builder.Append(property.GetValue(map));
                    }
                }

                builder.AppendLine();
            }

            return builder.ToString();
        }

        public IReadOnlyList<string> GetDefaultItems()
        {
            return (
                from p in typeof(Project).GetProperties()
                let o = p.GetCustomAttribute<JsonPropertyAttribute>()
                let d = p.GetCustomAttribute<TextDefaultDisplayAttribute>()
                where o != null && d != null
                orderby o.Order
                select p.Name).ToArray();
        }
    }
}
