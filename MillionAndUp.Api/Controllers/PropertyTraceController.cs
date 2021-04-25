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
    public class PropertyTraceController : Controller
    {
        private readonly IPropertyTraceService _PropertyTraceService;
        public PropertyTraceController(IPropertyTraceService PropertyTraceService)
        {
            _PropertyTraceService = PropertyTraceService;
        }
        [HttpGet]
        public IEnumerable<PropertyTrace> Get()
        {
            return _PropertyTraceService.GetPropertyTraces();
        }
    }
}
