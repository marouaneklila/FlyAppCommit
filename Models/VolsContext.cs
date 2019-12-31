using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FlyApp.Models
{
    public class VolsContext : DbContext
    {
        protected VolsContext() : base("flyapp_DBEntities") { }

        public DbSet<DAL.vols> Vols { get; set; }
    }
}
