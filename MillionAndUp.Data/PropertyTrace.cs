using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Data
{
    public class PropertyTrace
    {
        public int PropertyTraceId { get; set; }
        public DateTime SaleDate { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal Tax { get; set; }
        public int PropertyId { get; set; }
        public virtual Property Property { get; set; }
    }
}
