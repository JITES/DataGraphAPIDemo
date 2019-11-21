using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataGrapiApi.DataLayer.Core
{
    public class DGContext : DbContext
    {

        public DGContext(DbContextOptions<DGContext> options)
            : base(options)
        {
        }

        //public DbSet<Sales> Sales { get; set; }
    }
}
