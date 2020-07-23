using Microsoft.EntityFrameworkCore;
using TestAppHg.API.Models;

namespace TestAppHg.API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Value> Values { get; set; }
        public DataContext(DbContextOptions opts) : base(opts) {}

    }
}