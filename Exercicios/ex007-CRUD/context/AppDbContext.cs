using Microsoft.EntityFrameworkCore;
using ex007_CRUD.Models;

namespace ex007_CRUD.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Series> Serie { get; set; }
    }
}