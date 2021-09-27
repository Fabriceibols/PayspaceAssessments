using NUnit.Framework;
using PayspaceAssessment.Service.TaxCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentUnitTest
{
    [TestFixture]
    public class FlatValueCalculatorUnitTests
    {
        private readonly ITaxCalculator _taxCalculator;

        public FlatValueCalculatorUnitTests()
        {
            _taxCalculator = new FlatValueTaxCalculator();
        }


        [Test]
        public void TestFlatValueTaxRetuns10000()
        {
            var annualIncome = 199999.0;

            var result = _taxCalculator.CalcualtionTax(annualIncome);

            Assert.AreEqual(9999.95, result);
        }

        [Test]
        public void TestFlatValueTaxMultipleFivePercentage()
        {
            var annualIncome = 21000.0;

            var result = _taxCalculator.CalcualtionTax(annualIncome);

            Assert.AreEqual(1050, result);
        }
    }
}
