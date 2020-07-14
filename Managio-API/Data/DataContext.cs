using Managio_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Managio_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }

        public DbSet<User> Users { get; set; }

    }
}