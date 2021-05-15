using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rema1000ApiProject.Models
{
    public class MeasurementUnit{
        [Key]
        public Guid MeasurementUnitID {get; set;}
        [Required]
        public string MeasurementUnitName { get; set; }
    }
}