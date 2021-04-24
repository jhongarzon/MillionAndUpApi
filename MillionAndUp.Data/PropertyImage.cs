using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Data
{
    public class PropertyImage
    {
        public int PropertyImageId { get; set; }
        public int PropertyId { get; set; }
        public string FilePath { get; set; }
        public bool Enabled { get; set; }
        public virtual Property Property { get; set; }
    }
}
