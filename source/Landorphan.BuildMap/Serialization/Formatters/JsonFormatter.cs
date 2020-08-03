using System.Collections.Generic;
using Landorphan.BuildMap.Model;
using Landorphan.BuildMap.Serialization.Converters;
using Newtonsoft.Json;

namespace Landorphan.BuildMap.Serialization.Formatters
{
    public class JsonFormatter : IFormatter
    {
        public string Write(Map map)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.Formatting = Formatting.Indented;
            settings.Converters.Add(new VersionStringJsonConverter());
            return JsonConvert.SerializeObject(map, settings);
        }

        public Map Read(string text)
        {
            return JsonConvert.DeserializeObject<Map>(text);
        }
    }
}