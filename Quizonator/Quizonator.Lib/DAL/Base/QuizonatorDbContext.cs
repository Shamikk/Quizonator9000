using Quizonator.Lib.BLL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quizonator.Lib.DAL.Base
{
    public class QuizonatorDbContext : DbContext
    {
        public DbSet<Quiz>  Quizes { get; set; }
        public QuizonatorDbContext()
        {

        }

        public QuizonatorDbContext(string connectionName)
            : base(connectionName)
        {
        }
    }
}
