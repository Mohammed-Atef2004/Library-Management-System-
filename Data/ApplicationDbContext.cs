using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Library_Management_System.Models;
namespace Library_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            var config = new ConfigurationBuilder().AddJsonFile("appsettings.Development.json").Build();
            var connectionString = config.GetSection("constr").Value;

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
