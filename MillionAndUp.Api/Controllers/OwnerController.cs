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
    public class OwnerController : Controller
    {
        private readonly IOwnerService _ownerService;
        public OwnerController(IOwnerService ownerService)
        {
            _ownerService = ownerService;
        }
        [HttpGet]
        public IEnumerable<Owner> Get()
        {
            return _ownerService.GetOwners();
        }
    }
}
