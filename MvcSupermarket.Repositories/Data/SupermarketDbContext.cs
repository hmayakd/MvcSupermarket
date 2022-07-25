using Microsoft.EntityFrameworkCore;
using MvcSupermarket.Models;

namespace MvcSupermarket.Repositories.Data
{
    public class SupermarketDbContext : DbContext
    {
        public SupermarketDbContext(DbContextOptions<SupermarketDbContext> options)
            : base(options)
        {

        }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
