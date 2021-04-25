using MillionAndUp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Domain.Services
{
    public interface IPropertyService
    {
        IEnumerable<Property> GetProperties();
        IEnumerable<Property> GetPropertiesByOwner(Owner owner);
        Property GetPropertyById(int propertyId);
    }
}
