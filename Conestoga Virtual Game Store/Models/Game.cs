using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.Models
{
    public class Game
    {
        public int id { get; set; }

        public ICollection<GameOwnership> members { get; set; }
    }
}
