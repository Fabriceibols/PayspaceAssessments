using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayspaceAssessment.Models.DbModel
{
    public class TblCalculationType
    {
        [Key]
        public int TaxTypeId { get; set; }
        public string TaxTypeName { get; set; }
        public ICollection<TblPostalCode> TblPostalCodes { get; set; }
    }
}
