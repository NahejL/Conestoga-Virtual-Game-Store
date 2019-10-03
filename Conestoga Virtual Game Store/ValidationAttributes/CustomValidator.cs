using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conestoga_Virtual_Game_Store.ValidationAttributes
{
    public class CustomValidator : ValidationAttribute
    {
        public CustomValidator()
        {
            //Set params [Attribute()]
        }
        public override bool IsValid(object value)
        {
            //Validate
            return base.IsValid(value);
        }
    }
}
