using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conestoga_Virtual_Game_Store.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Conestoga_Virtual_Game_Store
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) { }

        #region Database Sets
        //Accessible Members
        public DbSet<Game> Games { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Moderator> Moderators { get; set; }

        public DbSet<Employee> Employees { get; set; }
        #endregion

    }

    public class StoreDbContextFactory : IDesignTimeDbContextFactory<StoreDbContext>
    {
        StoreDbContext IDesignTimeDbContextFactory<StoreDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<StoreDbContext>();
            var connectionString = configuration.GetConnectionString("GameStoreDB");

            //builder.UseSqlServer(connectionString);
            builder.UseSqlServer(connectionString);

            return new StoreDbContext(builder.Options);
        }
    }
}
