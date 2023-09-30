using laptopProj.Models;
using Microsoft.EntityFrameworkCore;

namespace laptopProj.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { 

        }
        
        public DbSet<Laptops> Laptopstbl {  get; set; }
        public DbSet<Cart> Carttbl { get; set; }

    }
}
