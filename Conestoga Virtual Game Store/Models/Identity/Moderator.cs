using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.Models
{
    public class Moderator //: Member
    {
        public int ModeratorProp { get; set; }
        #region Navigations
        //validated Reviews
        public ICollection<Review> validatedReviews { get; set; }

        #endregion

    }
    public class ModeratorMap : IEntityTypeConfiguration<Moderator>
    {
        public void Configure(EntityTypeBuilder<Moderator> builder)
        {
            builder
                .HasMany(m => m.validatedReviews)
                .WithOne();
        }
    }
}
