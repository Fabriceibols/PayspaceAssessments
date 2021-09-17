using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayspaceAssessment.Models.DbModel;

namespace PayspaceAssessment.Models.Sql
{
    public interface ISqlRepository
    {
        IReadOnlyCollection<TblPostalCode> GetPostalCodes();
        IReadOnlyCollection<TblRate> GetRates();
        IReadOnlyCollection<TblTaxCalculation> GetTaxCalculations();

        TblCalculationType GetCalculationType(int id);
        TblPostalCode GetPostalCode(string postalCode);
        bool Save(TblTaxCalculation taxCalculation);
    }
}
