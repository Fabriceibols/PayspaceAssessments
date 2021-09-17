using PayspaceAssessment.Models.ViewModels;
using PayspaceAssessment.Service.TaxCalculation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayspaceAssessment.Service.TaxCalculation
{
    public interface ITaxCalculation
    {
        CalculationResponse CalculationIncomeTax(TaxViewModel taxViewModel);
    }
}
