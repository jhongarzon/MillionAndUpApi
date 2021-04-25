using MillionAndUp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Domain.Services
{
    public interface IPropertyImageService
    {
        IEnumerable<PropertyImage> GetPropertyImages();
        IEnumerable<PropertyImage> GetPropertyImagesByProperty(Property property);
        PropertyImage GetPropertyImageById(int propertyImageId);
    }
}
