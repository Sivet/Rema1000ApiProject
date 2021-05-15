using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rema1000ApiProject.Models
{
    public class ContactPerson{
        [Key]
        public Guid ContactPersonID {get; set;}
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
        public Supplier ContactSupplier { get; set; }
    }
}