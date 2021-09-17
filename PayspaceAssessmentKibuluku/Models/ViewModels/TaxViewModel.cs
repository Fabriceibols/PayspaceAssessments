using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayspaceAssessment.Models.ViewModels
{
    public class TaxViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Annual income")]
        public double AnnualIncome { get; set; }
        [Display(Name = "Postal code")]
        public string PostalCode { get; set; }
    }
}
