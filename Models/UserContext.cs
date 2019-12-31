using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FlyApp.Models
{
    public class UserContext : DbContext
    {
        protected UserContext() : base("flyapp_DBEntities") {  }

        public DbSet<DAL.User> Users { get; set; }
    }
}
