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
        private readonly List<TblRate> _rate;

        public ProgressiveTaxCalculator(List<TblRate> rate)
        {
            _rate = rate;
        }
        public double CalcualtionTax(double annualIncome)
        {
            var percentage = _rate.Find(x => x.FromRate <= (decimal)annualIncome
            && x.ToRate >= (decimal)annualIncome)
            .Rate;
            var toRate = _rate.Find(x => x.FromRate <= (decimal)annualIncome
            && x.ToRate >= (decimal)annualIncome)
            .FromRate;
            var tax = 0.0m;
            var fixedAmount = 0.0m;
            var fixedAmount1 = 835m;
            var fixedAmount2 = 4675m;
            var fixedAmount3 = 16750m;
            var fixedAmount4 = 41754m; 
            var fixedAmount5 = 108216m;
            if (percentage == 10)
            {
                tax = ((decimal)annualIncome * percentage) / 100;
            }
            else if (percentage == 15)
            {
                fixedAmount = fixedAmount1;
               decimal excessIncome = (decimal)annualIncome - toRate;
                tax = Math.Round((excessIncome * percentage / 100) + fixedAmount, 2);
            }
            else if (percentage == 25)
            {
                fixedAmount = fixedAmount1 + fixedAmount2;
                decimal excessIncome = (decimal)annualIncome - toRate;
                tax = Math.Round((excessIncome * percentage / 100) + fixedAmount, 2);
            }
            else if (percentage == 28)
            {
                fixedAmount = fixedAmount1 + fixedAmount2 + fixedAmount3;
                decimal excessIncome = (decimal)annualIncome - toRate;
                tax = Math.Round((excessIncome * percentage / 100) + fixedAmount, 2);
            }
            else if (percentage == 33)
            {
                fixedAmount = fixedAmount1 + fixedAmount2 + fixedAmount3 + fixedAmount4 ;
                decimal excessIncome = (decimal)annualIncome - toRate;
                tax = Math.Round((excessIncome * percentage / 100) + fixedAmount, 2);
            }
            else 
            {
                fixedAmount = fixedAmount1 + fixedAmount2 + fixedAmount3 + fixedAmount4 + fixedAmount5;
                decimal excessIncome = (decimal)annualIncome - toRate;
                tax = Math.Round((excessIncome * percentage / 100) + fixedAmount, 2);
            }
            return (double)tax;
        }
    }
}
