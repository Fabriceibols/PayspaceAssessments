using Microsoft.EntityFrameworkCore;
using PayspaceAssessment.Models.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayspaceAssessment.Models.Sql
{
    public class TaxDbContext : DbContext
    {
        public TaxDbContext()
        {

        }

        public TaxDbContext(DbContextOptions<TaxDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=hp-probook\SQLEXPRESS;Database=TaxCalculator;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        public DbSet<TblRate> TblRate { get; set; }
        public DbSet<TblCalculationType> TblCalculationType { get; set; }
        public DbSet<TblPostalCode> TblPostalCode { get; set; }
        public DbSet<TblTaxCalculation> TblTaxCalculation { get; set; }
    }
}
