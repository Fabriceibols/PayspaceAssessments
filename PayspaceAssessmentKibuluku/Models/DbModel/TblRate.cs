using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayspaceAssessment.Models.DbModel
{
    public class TblRate
    {
        [Key]
        public int RateId { get; set; }
        public decimal Rate { get; set; }
        public decimal FromRate { get; set; }
        public decimal ToRate { get; set; }
    }
}
