using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.Models
{
    public class UserRole : IdentityUserRole<string>
    {
        [Required]
        public virtual Member User { get; set; }
        [Required]
        public virtual Role Role { get; set; }
    }
}
