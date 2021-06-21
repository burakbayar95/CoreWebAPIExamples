using IntroWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Business
{
    public class ProductRepository
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>()
            {
              new Product{ Id=2, ImageUrl="adadsa", Money=55,Description="asfdsdsfsd"}, //liste oluşurken daha eklendi içine. spr
              new Product{ Id=3, Money=40, IsActive=true,Time=DateTime.Now}
            };
            products.Add(new Product { Id = 1, ImageUrl = "www.gsfsdf.com/sdfds", Description = "güzel ürün" });

            return products;
        }
    }
}
