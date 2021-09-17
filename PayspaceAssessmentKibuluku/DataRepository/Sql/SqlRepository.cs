using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PayspaceAssessment.Models.DbModel;


namespace PayspaceAssessment.Models.Sql
{
    public class SqlRepository : ISqlRepository
    {
        private readonly TaxDbContext _taxDbContext;

        public SqlRepository()
        {
            _taxDbContext = new TaxDbContext();
        }

        public TblCalculationType GetCalculationType(int id)
        {
            return _taxDbContext.TblCalculationType.Where(x => x.TaxTypeId == id).SingleOrDefault();
        }

        public TblPostalCode GetPostalCode(string postalCode)
        {
            return _taxDbContext.TblPostalCode.SingleOrDefault(x => x.PostalCode == postalCode);
        }

        public IReadOnlyCollection<TblPostalCode> GetPostalCodes()
        {
            return _taxDbContext.TblPostalCode.ToList();
        }

        public IReadOnlyCollection<TblRate> GetRates()
        {
            return _taxDbContext.TblRate.ToList();
        }

        public IReadOnlyCollection<TblTaxCalculation> GetTaxCalculations()
        {
            return _taxDbContext.TblTaxCalculation.ToList();
        }

        public bool Save(TblTaxCalculation taxCalculation)
        {
            _taxDbContext.TblTaxCalculation.Add(taxCalculation);
            var result =_taxDbContext.SaveChanges();

            if (result > double.Epsilon)
                return true;

            return false;
        }
    }
}
