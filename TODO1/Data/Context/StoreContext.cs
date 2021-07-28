using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TODO1.Data; 

namespace TODO1.Data.Context
{
    public class StoreContext 
        : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { 
        
        }        
        public DbSet<Items> Items { get; set; }
    }
}
