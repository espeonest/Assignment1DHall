using Assignment1DHall.Data;
using Assignment1DHall.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment1DHall.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LakesController : ControllerBase
    {
        private readonly AppDbContext _context;
        
        public LakesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/<LakesController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Lake>>> Get()
        {
            return await _context.Lakes.ToListAsync();
        }

        // GET api/<LakesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Lake>> Get(int id)
        {
            var lake = await _context.Lakes.FindAsync(id);
            if (lake == null)
            {
                return NotFound();
            }

            return lake;
        }

        // POST api/<LakesController>
        [HttpPost]
        public async Task<ActionResult<Lake>> Post([FromBody] Lake value)
        {
            _context.Lakes.Add(value);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Post), new { id = value.Id }, value);
        }

        // PUT api/<LakesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Lake value)
        {
            if (id != value.Id)
            {
                return BadRequest();
            }

            _context.Entry(value).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                return BadRequest();
            }

            return NoContent();
        }

        // DELETE api/<LakesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = await _context.Lakes.FindAsync(id);
            if (value == null)
            {
                return NotFound();
            }

            _context.Lakes.Remove(value);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
