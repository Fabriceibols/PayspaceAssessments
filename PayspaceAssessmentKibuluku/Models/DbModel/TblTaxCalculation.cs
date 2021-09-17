using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayspaceAssessment.Models.DbModel
{
    public class TblTaxCalculation
    {
        [Key]
        [Display(Name = "Id")]
        public int TaxCalculationId {get;set;}
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Tax Calculated")]
        public decimal TaxCalculated { get; set; }
        [Display(Name = "Annual Income")]
        public decimal AnnualIncome { get; set; }
        [Display(Name = "Tax Type")]
        public string CalculationType { get; set; }
    }
}
