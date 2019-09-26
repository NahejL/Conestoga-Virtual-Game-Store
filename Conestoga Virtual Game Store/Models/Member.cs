using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.Models
{
    enum memberTypes
    {
        member, moderator, employee
    }
    public class Member : Table
    {

        #region Navigations
        //Owned Games 
        public ICollection<Ownership> games { get; set; }
        
        //Relatives 
        public ICollection<Familyship> relatives0 { get; set; }
        public ICollection<Familyship> relatives1 { get; set; }

        //Friends 
        public ICollection<Friendship> friends0 { get; set; }
        public ICollection<Friendship> friends1 { get; set; }

        //Credit Cards 
        public ICollection<CreditCard> creditCards { get; set; }

        //Wishes
        public ICollection<Wish> wishes { get; set; }

        //Reviews
        public ICollection<Review> reviews { get; set; }

        //Orders
        public ICollection<Order> orders { get; set; }

        //Registrations
        public ICollection<Registration> registrations { get; set; }

        //Ratings
        public ICollection<Rating> ratings { get; set; }
        #endregion

    }
    public class MemberMap : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder
                .HasDiscriminator<memberTypes>("member_type")
                .HasValue<Member>(memberTypes.member)
                .HasValue<Moderator>(memberTypes.moderator)
                .HasValue<Employee>(memberTypes.employee);

            builder
                .HasMany(m => m.games)
                .WithOne();
            builder
                .HasMany(m => m.relatives0)
                .WithOne();
            builder
                .HasMany(m => m.relatives1)
                .WithOne();
            builder
                .HasMany(m => m.friends0)
                .WithOne();
            builder
                .HasMany(m => m.friends1)
                .WithOne();
            builder
                .HasMany(m => m.creditCards)
                .WithOne();
            builder
                .HasMany(m => m.wishes)
                .WithOne();
            builder
                .HasMany(m => m.reviews)
                .WithOne();
            builder
                .HasMany(m => m.orders)
                .WithOne();
            builder
                .HasMany(m => m.registrations)
                .WithOne();
            builder
                .HasMany(m => m.ratings)
                .WithOne();
        }
    }
}
