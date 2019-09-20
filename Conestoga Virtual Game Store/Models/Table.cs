using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.Models
{
    public class Table
    {
        //Most tables have an ID, looks clearner
        [Key]
        public int id { get; set; }
    }
}
