using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PayspaceAssessment.Models.DbModel
{
    public class TblPostalCode
    {
        [Key]
        public int PostalCodeId { get; set; }
        public string PostalCode { get; set; }
        [ForeignKey("TblCalculationType")]
        public int TaxTypeId { get; set; }
        public TblCalculationType TblCalculationType { get; set; }
    }
}
