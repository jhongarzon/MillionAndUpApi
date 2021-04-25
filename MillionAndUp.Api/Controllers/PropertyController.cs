using Microsoft.AspNetCore.Mvc;
using MillionAndUp.Data;
using MillionAndUp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MillionAndUp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropertyController : Controller
    {
        private readonly IPropertyService _propertyService;
        public PropertyController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }

        [HttpGet]
        public IEnumerable<Property> Get()
        {
            return _propertyService.GetProperties();
        }
    }
}
