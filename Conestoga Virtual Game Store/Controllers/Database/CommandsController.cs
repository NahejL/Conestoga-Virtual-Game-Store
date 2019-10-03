using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Conestoga_Virtual_Game_Store;
using Conestoga_Virtual_Game_Store.Models;

namespace Conestoga_Virtual_Game_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly StoreDbContext _context;

        public CommandsController(StoreDbContext context)
        {
            _context = context;
        }

        // GET: api/Commands
        [HttpGet]
        public IEnumerable<Command> GetCommand()
        {
            return _context.Command;
        }

        // GET: api/Commands/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCommand([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = await _context.Command.FindAsync(id);

            if (command == null)
            {
                return NotFound();
            }

            return Ok(command);
        }

        // PUT: api/Commands/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommand([FromRoute] int id, [FromBody] Command command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != command.id)
            {
                return BadRequest();
            }

            _context.Entry(command).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommandExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Commands
        [HttpPost]
        public async Task<IActionResult> PostCommand([FromBody] Command command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Command.Add(command);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommand", new { id = command.id }, command);
        }

        // DELETE: api/Commands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommand([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var command = await _context.Command.FindAsync(id);
            if (command == null)
            {
                return NotFound();
            }

            _context.Command.Remove(command);
            await _context.SaveChangesAsync();

            return Ok(command);
        }

        private bool CommandExists(int id)
        {
            return _context.Command.Any(e => e.id == id);
        }
    }
}