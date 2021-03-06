using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MillionAndUp.Data
{
    public class Property
    {
        public Property()
        {
            PropertyImages = new HashSet<PropertyImage>();
            PropertyTraces = new HashSet<PropertyTrace>();

        }
        [JsonPropertyName("propertyId")]
        public int PropertyId { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
        public string InternalCode { get; set; }
        public int Year { get; set; }
        public ICollection<PropertyImage> PropertyImages { get; set; }
        public ICollection<PropertyTrace> PropertyTraces { get; set; }
        public int OwnerId { get; set; }
        public Owner Owner { get; set; }
    }
}
