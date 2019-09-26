using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conestoga_Virtual_Game_Store.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Conestoga_Virtual_Game_Store.Controllers
{
    public class UserController : ODataController
    {
        #region Constructor
        //Db connection
        private StoreDbContext _db;

        //Constructor
        public UserController(StoreDbContext context)
        {
            _db = context;
        }
        #endregion
        //SELECT users
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Games);
        }

        //SELECT user WHERE user.name = name
        [EnableQuery]
        public IActionResult Get(string name)
        {
            return Ok(_db.Games.FirstOrDefault(g => g.id.ToString() == name));
        }

        //INSERTE () INTO users
        [Authorize("Employee")]
        [EnableQuery]
        public IActionResult Post([FromBody]User user)
        {
            _db.Add(user);
            _db.SaveChanges();
            return Created(user);
        }
    }
}