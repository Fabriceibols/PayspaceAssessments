using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PayspaceAssessment.Models;
using PayspaceAssessment.Models.ViewModels;
using PayspaceAssessment.Models.Sql;
using PayspaceAssessment.Service.TaxCalculation;

namespace PayspaceAssessment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISqlRepository _sqlRepository;
        private readonly ITaxCalculation _taxCalculation;
 

      

        public HomeController(ISqlRepository sqlRepository,
            ITaxCalculation taxCalculation)
        {
            _sqlRepository = sqlRepository;
            _taxCalculation = taxCalculation;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var postalCodes = _sqlRepository.GetPostalCodes();

            ViewBag.PostalCodes = new SelectList(postalCodes, "PostalCode", "PostalCode");

            return View();
        }

        [HttpPost]
        public IActionResult Index(TaxViewModel taxViewModel)
        {
            if (ModelState.IsValid)
            {
                var taxCalculatedResponse = _taxCalculation.CalculationIncomeTax(taxViewModel);

                if (taxCalculatedResponse != null)
                {
                    var taxCalculationModel = new Models.DbModel.TblTaxCalculation
                    {
                        AnnualIncome = (decimal)taxViewModel.AnnualIncome,
                        Name = taxViewModel.Name.ToLower(),
                        TaxCalculated = (decimal)taxCalculatedResponse.CalculatedTax,
                        CalculationType = taxCalculatedResponse.CalculationType.ToLower(),
                        DateCreated = DateTime.Now
                    };

                    var hasSaved = _sqlRepository.Save(taxCalculationModel);

                    
                }
            }

            return RedirectToAction("Index", "Report");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
