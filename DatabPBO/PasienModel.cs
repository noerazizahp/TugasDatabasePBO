using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DatabPBO
{
    public partial class PasienModel : DbContext
    {
        public PasienModel()
            : base("name=PasienModel")
        {
        }

        public virtual DbSet<Pasien> Pasiens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
