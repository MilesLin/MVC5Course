using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    public class ProductViewModel
    {
        [Required]
        public string ProductName { get; set; }
        
        [Range(0, int.MaxValue)]
        [Required]
        public Nullable<decimal> Price { get; set; }
    }
}