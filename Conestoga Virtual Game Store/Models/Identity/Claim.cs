using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.Models.Identity
{
    [Flags]
    enum Claims
    {
        CCommand = 1, RCommand = 2, UCommand = 4, DCommand = 8,
        CCreditCard = 16, RCreditCard = 32, UCreditCard = 64, DCreditCard = 128,
        CEvent, REvent, UEvent, DEvent,

    }
}
