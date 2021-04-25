using MillionAndUp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Domain.Services
{
    public class PropertyService : IPropertyService
    {
        private readonly MillionUpDbContext _context;
        public PropertyService()
        {
            _context = new MillionUpDbContext();
        }
        public IEnumerable<Property> GetProperties()
        {
            return _context.Properties;
        }

        public IEnumerable<Property> GetPropertiesByOwner(Owner owner)
        {
            return _context.Properties.Where(x=> x.OwnerId == owner.OwnerId);
        }

        public Property GetPropertyById(int propertyId)
        {
            return _context.Properties.Find(propertyId);
        }
    }
}
