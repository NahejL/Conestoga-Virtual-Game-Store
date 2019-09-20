using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.Models
{
    public class Game : Table
    {
        #region Navigation
        //Owned by
        public ICollection<Ownership> owners { get; set; }

        //Wished by
        public ICollection<Wish> wishes { get; set; }

        //Rated by
        public ICollection<Rating> ratings { get; set; }

        //Ordered by
        public ICollection<Command> commands { get; set; }

        //Reviewed by
        public ICollection<Review> reviews { get; set; }
        #endregion
    }
    public class GameMap : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder
                .HasMany(g => g.owners)
                .WithOne();
            builder
                .HasMany(g => g.wishes)
                .WithOne();
            builder
                .HasMany(g => g.ratings)
                .WithOne();
            builder
                .HasMany(g => g.commands)
                .WithOne();
            builder
                .HasMany(g => g.reviews)
                .WithOne();
        }
    }
}
