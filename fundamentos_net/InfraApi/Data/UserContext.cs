using System;
using CoreApi.Models;
using Microsoft.EntityFrameworkCore;
using InfraApi.Data.Configurations;

namespace InfraApi.Data
{
    public class UserContext : DbContext
    {
        public UserContext() { }
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Word> Words{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string stringConnection = "Server=localhost; Database=LoginNetCore;User=root;Password=12345678";
            var versionMaria = new MariaDbServerVersion(new Version(10,6,3));
            optionsBuilder.UseMySql(stringConnection,versionMaria);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new WordConfiguration());
        }
    }
}