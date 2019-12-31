using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FlyApp.Models
{
    public class AvionContext : DbContext
    {
        protected AvionContext() : base("flyapp_DBEntities") { }

        public DbSet<DAL.avion> Avions { get; set; }
    }
}
