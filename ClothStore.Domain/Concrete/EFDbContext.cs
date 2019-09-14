using ClothStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothStore.Domain.Concrete
{
   public class EFDbContext:DbContext
    {
        public DbSet<Product> Product { get; set; }
    }
}

