using IntroWebAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Business
{
    public class ProductServices
    {
        public List<ProductListResponseDTO> GetListResponseDTOs() //geriye döndüreceği tipte açtık List<ProductListResponseDTO>
        {
            ProductRepository repo = new ProductRepository();

            var products = repo.GetAllProducts(); //  ProductRepository den tüm ürünleri çektik


            //veriyi döndürdüğümüz yer
            List<ProductListResponseDTO> dtoList = new List<ProductListResponseDTO>(); 

            foreach (var product in products)
            {
                var dto = new ProductListResponseDTO  // sadece göstermek istediğimiz bilgileri product tan çektik
                                                      // product şuan veritabanı gibi
                {
                    Description = product.Description,
                    Id = product.Id,
                    ImageUrl = product.ImageUrl,
                    Money = product.Money

                };
                dtoList.Add(dto);

            }



            return dtoList;
        }
    }
}
