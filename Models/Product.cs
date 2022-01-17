using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecrap.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "product name is required")]
        [Display(Name = "product name")]
        public string Pname { get; set; }

        [Required(ErrorMessage = "Description is required")]

        public string Description { get; set; }

        [Required(ErrorMessage = "price is required")]

        public string price { get; set; }


    }
}