using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.Models
{
    public class Friendship
    {
        public int id { get; set; }

        public int friend0Id { get; set; }
        [ForeignKey("friends")]
        public Member friend0 { get; set; }

        public int friend1Id { get; set; }
        [ForeignKey("friends")]
        public Member friend1 { get; set; }
    }
}
