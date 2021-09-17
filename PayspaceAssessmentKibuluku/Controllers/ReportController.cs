using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PayspaceAssessment.Models;
using PayspaceAssessment.Models.Sql;

namespace PayspaceAssessment.Controllers
{
    public class ReportController : Controller
    {
        private readonly ISqlRepository _sqlRepository;

        public ReportController(ISqlRepository sqlRepository)
        {
            _sqlRepository = sqlRepository;
        }

        public IActionResult Index()
        {
            var taxCalculations = _sqlRepository.GetTaxCalculations();

            return View(taxCalculations);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}