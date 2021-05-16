using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rema1000ApiProject.Models
{
    public class Product{
        [Key]
        public Guid ProductID {get; set;}
        [Required]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal GrossPrice { get; set; }
        public int UnitsInStock { get; set; }
        public MeasurementUnit Unit { get; set; }
        public Category ProductCategory { get; set; }
        public Supplier ProductSupplier { get; set; }
    }
}