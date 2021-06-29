using DIDemoinAPI.Data;
using DIDemoinAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemoinAPI.Services
{
    public class ProductServices : IProductService
    {
        private DataDbContext dataDbContex;

        public ProductServices(DataDbContext dataDbContext)
        {
            this.dataDbContex = dataDbContext;
        }
        public IList<Product> GetProducts()
        {
            return dataDbContex.Products.ToList();
        }
    }
}
