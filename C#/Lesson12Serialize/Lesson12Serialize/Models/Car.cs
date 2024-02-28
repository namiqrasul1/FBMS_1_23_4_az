using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson12Serialize.Models
{
    [Serializable]
    public class Car
    {
        [JsonPropertyName("identifier")]
        public int Id { get; set; }
        [XmlElement]
        public string Vendor { get; set; }
        [XmlElement]
        public string Model { get; set; }
        [XmlElement]
        public int Year { get; set; }

        public override string ToString() => $"{Id} {Vendor} {Model} {Year}";
    }
}
