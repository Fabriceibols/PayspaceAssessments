using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayspaceAssessment.Service.TaxCalculation.Models
{
    public class CalculationResponse
    {
        public double CalculatedTax { get; set; }
        public string CalculationType { get; set; }
    }
}
