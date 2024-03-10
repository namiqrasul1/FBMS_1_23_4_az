using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lesson15.Models
{
    internal class User
    {
        [JsonPropertyName("kamil")]
        public string Name { get; set; }
        public Car Car { get; set; }

        public User(string name, Car car)
        {
            Name = name;
            Car = car;
        }
    }
}
