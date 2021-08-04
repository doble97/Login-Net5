using System;
using CoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace InfraApi.Data
{
    public class UserContext : DbContext
    {
        public UserContext() { }
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConnection = "Server=localhost; Database=LoginNetCore;User=root;Password=12345678";
            var versionMaria = new MariaDbServerVersion(new Version(10,6,3));
            optionsBuilder.UseMySql(stringConnection,versionMaria);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(p => p.Id).IsRequired();
        }
    }
}