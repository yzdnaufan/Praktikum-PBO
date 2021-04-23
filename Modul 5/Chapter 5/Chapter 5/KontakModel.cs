using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Chapter_5
{
    public partial class KontakModel : DbContext
    {
        public KontakModel()
            : base("name=KontakModel")
        {
        }

        public virtual DbSet<Kontak> Kontaks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
