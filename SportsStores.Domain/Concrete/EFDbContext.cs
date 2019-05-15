using SportsStore.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStores.Domain.Concrete
{
    public class EFDbContext : System.Data.Entity.DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
