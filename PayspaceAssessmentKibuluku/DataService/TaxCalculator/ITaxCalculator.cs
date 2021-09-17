using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayspaceAssessment.Service.TaxCalculator
{
    public interface ITaxCalculator
    {
        double CalcualtionTax(double annualIncome);
    }
}
