using System.IO;
using System.Text;
using System.Xml;
using Landorphan.BuildMap.Model;
using Landorphan.BuildMap.Model.Support;
using Landorphan.BuildMap.Serialization.Formatters.Interfaces;

namespace Landorphan.BuildMap.Serialization.Formatters.Implementation
{
    using System;
    using Landorphan.Common;

    public class XmlFormatter : IFormatter
    {
        private readonly System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(
            typeof(Map), new[] { typeof(Project), typeof(VersionString), typeof(Build) }); 
        
        public string Write(Map map)
        {
            string result;
            using (MemoryStream stream = new MemoryStream())
            using (XmlTextWriter writer = new XmlTextWriter(stream, Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, map);
                result = Encoding.UTF8.GetString(stream.ToArray());
            }

            return result;
        }

        public bool SniffValidFormat(string text)
        {
            text.ArgumentNotNull(nameof(text));
            return text.StartsWith("<", StringComparison.OrdinalIgnoreCase);
        }

        public Map Read(string text)
        {
            Map result;
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            using (MemoryStream stream = new MemoryStream(bytes))
            using (XmlTextReader reader = new XmlTextReader(stream))
            {
                result = (Map) serializer.Deserialize(reader);
            }

            return result;
        }
    }
}