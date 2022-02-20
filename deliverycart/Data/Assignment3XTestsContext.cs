#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using deliverycart.Models;

namespace deliverycart.Data
{
    public class Assignment3XTestsContext : DbContext
    {
        public Assignment3XTestsContext (DbContextOptions<Assignment3XTestsContext> options)
            : base(options)
        {
        }

        public DbSet<deliverycart.Models.Order> Order { get; set; }
        // public DbSet<deliverycart.Models.Item> Item { get; set; }
        // public DbSet<deliverycart.Models.Customer> Customer { get; set; }
        // public DbSet<deliverycart.Models.Vendor> Vendor { get; set; }
        // public DbSet<deliverycart.Models.Manager> Manager { get; set; }
        // public DbSet<deliverycart.Models.Shopper> Shopper { get; set; }

        #region snippet2
        public async virtual Task AddOrderAsync (deliverycart.Models.Order order){
           await Order.AddAsync(order);
           await SaveChangesAsync();
        }
        #endregion
    }
}
