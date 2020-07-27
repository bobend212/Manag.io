using Managio_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Managio_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserProject> UserProjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserProject>()
                .HasKey(t => new { t.UserId, t.ProjectId });

            modelBuilder.Entity<UserProject>()
                .HasOne(pt => pt.User)
                .WithMany(p => p.UserProjects)
                .HasForeignKey(pt => pt.UserId);

            modelBuilder.Entity<UserProject>()
                .HasOne(pt => pt.Project)
                .WithMany(t => t.UserProjects)
                .HasForeignKey(pt => pt.ProjectId);

            base.OnModelCreating(modelBuilder);
        }

    }
}