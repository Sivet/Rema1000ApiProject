using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rema1000ApiProject.Models
{
    public class Supplier{
        [Key]
        public Guid SupplierID {get; set;}
        [Required]
        public string SupplierName { get; set; }
        public List<Product> SupplierProducts { get; set; }
        public List<Address> SupplierAddresses { get; set; }
        public List<ContactPerson> SupplierContacts { get; set; }
    }
}