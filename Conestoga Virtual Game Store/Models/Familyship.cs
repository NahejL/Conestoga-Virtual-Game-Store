using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.Models
{
    public class Familyship
    {
        public int id { get; set; }

        public int relative0Id { get; set; }
        [ InverseProperty("relatives")]
        public Member relative0 { get; set; }

        public int relative1Id { get; set; }
        [ InverseProperty("relatives")]
        public Member relative1 { get; set; }

    }
}
