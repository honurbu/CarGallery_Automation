using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CarGallery
{
    public partial class CarDbEntities2 : DbContext
    {
        public CarDbEntities2()
            : base("name=CarDbEntities2")
        {
        }

        public virtual DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
