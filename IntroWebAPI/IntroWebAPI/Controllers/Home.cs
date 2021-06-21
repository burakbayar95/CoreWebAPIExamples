using IntroWebAPI.Business;
using IntroWebAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace IntroWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home : ControllerBase
    {
        public IActionResult Getir()
        {
            ProductServices dataservice = new ProductServices(); //ProductServices te yapıtığımız işlemleri controller da çağırdık
            var list = dataservice.GetListResponseDTOs();
            return Ok(list);

        }
    }
}