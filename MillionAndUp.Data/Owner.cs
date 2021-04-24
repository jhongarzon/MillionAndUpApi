﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Data
{
    public class Owner
    {
        public Owner()
        {
            Properties = new HashSet<Property>();
        }
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public DateTime Birthday { get; set; }
        public virtual ICollection<Property> Properties { get; set; }
    }
}
