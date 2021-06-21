using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroWebAPI.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Money { get; set; }


        // daha fazla ayrıntı - kullanıcının bilmesi gerekmeyen ve tutmamız gereke bilgiler

        public List<string> Properties { get; set; }
        public List<string> Colors { get; set; }

        public DateTime Time { get; set; }

        public bool IsActive { get; set; }
    }
}