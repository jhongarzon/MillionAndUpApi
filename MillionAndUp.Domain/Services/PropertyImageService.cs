using MillionAndUp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Domain.Services
{
    public class PropertyImageService : IPropertyImageService
    {
        private readonly MillionUpDbContext _context;
        public PropertyImageService()
        {
            _context = new MillionUpDbContext();
        }

        public PropertyImage GetPropertyImageById(int propertyImageId)
        {
            return _context.PropertyImages.Find(propertyImageId);
        }

        public IEnumerable<PropertyImage> GetPropertyImages()
        {
            return _context.PropertyImages;
        }

        public IEnumerable<PropertyImage> GetPropertyImagesByProperty(Property property)
        {
            return _context.PropertyImages.Where(x => x.PropertyId == property.PropertyId);
        }
    }
}
