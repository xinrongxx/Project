using CarRentalManagement.Shared.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
    public class Buses : BaseDomainModel
    {
        [Required]
        [DataType(DataType.Date)]
        public int BusSeater { get; set; }
        public string Type { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Amount { get; set; }
    }
}