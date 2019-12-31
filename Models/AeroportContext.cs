using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FlyApp.Models
{
    public class AeroportContext : DbContext
    {
        protected AeroportContext() : base("flyapp_DBEntities") { }

        public DbSet<DAL.aeroport> Aeroports { get; set; }
    }
}
