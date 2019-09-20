using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.Models
{
    public class Event : Table
    {
        #region Navigation
        //Registrations to Attendees
        public ICollection<Registration> registrations { get; set; }
        #endregion
    }
    public class EventMap : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder
                .HasMany(e => e.registrations)
                .WithOne();
        }
    }
}
