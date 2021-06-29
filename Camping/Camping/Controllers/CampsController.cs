using Camping.Models;
using Camping.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampsController : ControllerBase
    {

        private ICampService service;
        public CampsController(ICampService service)
        {
            this.service = service;
        }
       public IActionResult Get()
        {
            var camps = service.GetCamps();
            return Ok(camps);
        }

    }
}
