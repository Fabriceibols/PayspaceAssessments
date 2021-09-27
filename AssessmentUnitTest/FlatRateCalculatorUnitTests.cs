using NUnit.Framework;
using PayspaceAssessment.Service.TaxCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssessmentUnitTest
{
    [TestFixture]
    public class FlatRateCalculatorUnitTests
    {
        private readonly ITaxCalculator _taxCalculator;

        public FlatRateCalculatorUnitTests()
        {
            _taxCalculator = new FlatRateTaxCalculator();
        }

        [Test]
        public void TestFlatRateTax()
        {
            var annualIncome = 100000.0;

            var result = _taxCalculator.CalcualtionTax(annualIncome);

            Assert.AreEqual(17500, result);
        }
    }
}
