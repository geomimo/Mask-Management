using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaskManagement.Data
{
    public class MaskManagementContext : DbContext
    {
        public MaskManagementContext(DbContextOptions<MaskManagementContext> options) :
            base(options)
        {
                
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Mask> Masks { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchasedMasks> PurchasedMasks { get; set; }

    }
}
