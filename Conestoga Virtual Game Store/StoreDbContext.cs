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

        //Accessible Members
        public DbSet<Game> games { get; set; }

        public DbSet<Member> members { get; set; }

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
