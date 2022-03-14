using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class Context : DbContext
    {
        public Context(): base("DatabaseConnection")
        {

        }

        public DbSet<Trainer> Trainer;
    }
}
