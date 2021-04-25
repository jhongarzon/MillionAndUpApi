using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class PropertyImageController : Controller
    {
        private readonly IPropertyImageService _PropertyImageService;
        public PropertyImageController(IPropertyImageService PropertyImageService)
        {
            _PropertyImageService = PropertyImageService;
        }
        [HttpGet]
        public IEnumerable<PropertyImage> Get()
        {
            return _PropertyImageService.GetPropertyImages();
        }
    }
}
