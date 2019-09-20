using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.Models
{
    public class Employee : Moderator
    {
        #region Navigations
        //Created Events
        public ICollection<Event> createdEvents { get; set; }

        //Created Games 
        public ICollection<Game> createdGames { get; set; }
        #endregion
    }

    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .HasMany(e => e.createdEvents)
                .WithOne();
            builder
                .HasMany(e => e.createdGames)
                .WithOne();
        }
    }
}
