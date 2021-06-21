using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Model
{ 

    //dto => data transfer object => istemcinin neye ihtiyacı varsa onu gönder
    public class ProductListResponseDTO
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Money { get; set; }

    }
}
