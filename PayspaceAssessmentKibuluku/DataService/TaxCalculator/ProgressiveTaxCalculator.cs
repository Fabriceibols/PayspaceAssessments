using PayspaceAssessment.Models.DbModel;
using PayspaceAssessment.Models.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayspaceAssessment.Service.TaxCalculator
{
    public class ProgressiveTaxCalculator : ITaxCalculator
    {
        private List<TblRate> _rate;

        public ProgressiveTaxCalculator(List<TblRate> rate)
        {
            _rate = rate;
        }
        public double CalcualtionTax(double annualIncome)
        {
            var percentage = _rate.Find(x => x.FromRate <= (decimal)annualIncome
            && x.ToRate >= (decimal)annualIncome)
            .Rate;

            var tax = ((decimal)annualIncome * percentage) / 100;

            return (double)tax;
        }
    }
}
