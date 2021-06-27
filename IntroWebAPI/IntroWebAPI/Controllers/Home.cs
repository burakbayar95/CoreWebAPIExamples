using IntroWebAPI.Business;
using IntroWebAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace IntroWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Home : ControllerBase
    {
        [HttpGet]
        public IActionResult AllProduct()
        {
            ProductServices dataservice = new ProductServices(); //ProductServices te yapıtığımız işlemleri controller da çağırdık
            var list = dataservice.GetListResponseDTOs();
            return Ok(list);


        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            ProductServices dataservice = new ProductServices();
            var product = dataservice.GetProductResponseDTO(id);

            if(product==null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            //varsayalım ki db ye ekledik..
            return CreatedAtAction(nameof(GetProductById), new { id = 3 });

        }
        [HttpPut("{id}")]
        public IActionResult Put(int id,Product product)
        {
            return Ok();
        }

    }
}