using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rema1000ApiProject.Models
{
    public class Address{
        [Key]
        public Guid AddressID {get; set;}
        [Required]
        public string StreetName { get; set; }
        public string StreetNr { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public Supplier Supplier { get; set; }
    }
}