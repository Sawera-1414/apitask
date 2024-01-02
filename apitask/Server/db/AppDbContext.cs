
using apitask.Client.Pages;
using apitask.Shared.Models;
using Microsoft.EntityFrameworkCore;
namespace apitask.Server.db
{// AppDbContext.cs
    

    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Remarks> Remarks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships and configurations


        }
    }

}
