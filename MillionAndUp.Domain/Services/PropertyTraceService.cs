using MillionAndUp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Domain.Services
{
    public class PropertyTraceService : IPropertyTraceService
    {
        private readonly MillionUpDbContext _context;
        public PropertyTraceService()
        {
            _context = new MillionUpDbContext();
        }

        public IEnumerable<PropertyTrace> GetPropertyImagesByProperty(Property property)
        {
            return _context.PropertyTraces.Where(x => x.PropertyId == property.PropertyId);
        }

        public PropertyTrace GetPropertyTraceById(int propertyTraceId)
        {
            return _context.PropertyTraces.Find(propertyTraceId);
        }

        public IEnumerable<PropertyTrace> GetPropertyTraces()
        {
            return _context.PropertyTraces;
        }
    }
}
