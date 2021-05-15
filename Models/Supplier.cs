using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rema1000ApiProject.Models
{
    public class Supplier{
        [Key]
        public Guid SupplierID {get; set;}
        [Required]
        public string SupplierName { get; set; }
    }
}