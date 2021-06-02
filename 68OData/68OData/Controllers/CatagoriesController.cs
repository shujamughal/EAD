using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _68OData.Models;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.AspNetCore.OData.Query;

namespace _68OData.Controllers
{
   // [Route("api/[controller]")]
   // [ApiController]
    public class CatagoriesController : ODataController //: ControllerBase ////
    {
        private readonly MySimpleShopContext _context;

        public CatagoriesController(MySimpleShopContext context)
        {
            _context = context;
        }

        // GET: api/Catagories
        //[HttpGet]
        [EnableQuery]
        public IEnumerable<Catagory> Get()
        {
            return _context.Catagories;
        }

        // GET: api/Catagories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Catagory>> GetCatagory(int id)
        {
            var catagory = await _context.Catagories.FindAsync(id);

            if (catagory == null)
            {
                return NotFound();
            }

            return catagory;
        }

        // PUT: api/Catagories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCatagory(int id, Catagory catagory)
        {
            if (id != catagory.Id)
            {
                return BadRequest();
            }

            _context.Entry(catagory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CatagoryExists(id))
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

        // POST: api/Catagories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Catagory>> PostCatagory(Catagory catagory)
        {
            _context.Catagories.Add(catagory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCatagory", new { id = catagory.Id }, catagory);
        }

        // DELETE: api/Catagories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCatagory(int id)
        {
            var catagory = await _context.Catagories.FindAsync(id);
            if (catagory == null)
            {
                return NotFound();
            }

            _context.Catagories.Remove(catagory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CatagoryExists(int id)
        {
            return _context.Catagories.Any(e => e.Id == id);
        }
    }
}
