using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rema1000ApiProject.Models
{
    public class ProductType{
        [Key]
        public Guid ProductTypeID {get; set;}
        [Required]
        public string ProductTypeName { get; set; }
        public string ProductTypeDescription { get; set; }
    }
}