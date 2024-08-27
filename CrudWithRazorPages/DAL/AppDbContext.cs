using CrudWithRazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudWithRazorPages.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
