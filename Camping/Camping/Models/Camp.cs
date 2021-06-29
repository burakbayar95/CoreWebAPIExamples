using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Camping.Models
{
    public class Camp
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string City { get; set; }
        public string Type  { get; set; }

        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

    }
}
