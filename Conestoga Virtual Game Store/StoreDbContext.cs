using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conestoga_Virtual_Game_Store.Models;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Conestoga_Virtual_Game_Store
{
    public class StoreDbContext : IdentityDbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder); 
        }

        #region Database Sets
        //Accessible Members
        public DbSet<Game> Games { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Command> Command { get; set; }

        public DbSet<CreditCard> CreditCard { get; set; }

        public DbSet<Event> Event { get; set; }

        public DbSet<Role> Role { get; set; }
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
