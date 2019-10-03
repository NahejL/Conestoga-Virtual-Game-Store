using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conestoga_Virtual_Game_Store.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conestoga_Virtual_Game_Store.Controllers
{
    public class GamesController : ODataController
    {
        //Db connection
        private StoreDbContext _db;

        //Constructor
        public GamesController(StoreDbContext context)
        {
           _db = context;
        }

        //SELECT games
        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Games);
        }

        //SELECT games WHERE game.id = id
        [EnableQuery]
        public IActionResult Get(int id)
        {
            return Ok(_db.Games.FirstOrDefault( g => g.id == id));
        }

        //INSERTE () INTO games
        //[Authorize("Employee")]
        [EnableQuery]
        public IActionResult Post([FromBody]Game game)
        {
            _db.Add(game);
            _db.SaveChanges();
            return Created(game);
        }
    }
}