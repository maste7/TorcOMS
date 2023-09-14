using Microsoft.EntityFrameworkCore;
using TorcOMS.Domain.Models;

namespace TorcOMS.Data.Context
{
    public class TorcOMSDbContext : DbContext
    {
        public TorcOMSDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
