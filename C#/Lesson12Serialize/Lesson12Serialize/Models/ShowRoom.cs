using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson12Serialize.Models
{
    [Serializable]
    public class ShowRoom
    {
        [XmlArray]
        public List<Car>? Cars { get; set; }
        [XmlAttribute]
        public string? Name { get; set; }

        [XmlAttribute]
        public string? Address { get; set; }

        [XmlAttribute("phone")]
        public string? PhoneNumber { get; set; }
    }
}
