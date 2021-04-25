using MillionAndUp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Domain.Services
{
    public interface IPropertyTraceService
    {
        IEnumerable<PropertyTrace> GetPropertyTraces();
        IEnumerable<PropertyTrace> GetPropertyImagesByProperty(Property property);
        PropertyTrace GetPropertyTraceById(int propertyTraceId);
    }
}
