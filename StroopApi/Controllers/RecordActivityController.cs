using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StroopApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StroopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordActivityController : ControllerBase
    {
        private readonly StroopApiContext _context;

        public RecordActivityController(StroopApiContext context)
        {
            _context = context;

            if (_context.RecordActivities.Count() == 0)
            {
                _context.RecordActivities.Add(new RecordActivity {
                    IdUser = 1, Stage = "1", Status = "Ok", Ink = "Rojo", Text = "Rojo", Time = DateTime.Now.ToString("MM/dd/yyyy H:mm:ss")
                });
                _context.SaveChanges();
            }
        }
        
        // GET: api/<controller>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecordActivity>>> GetAll()
        {
            return await _context.RecordActivities.ToListAsync();
        }
        
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecordActivity>> Get(long id)
        {
            var recordActivity = await _context.RecordActivities.FindAsync(id);
            if (recordActivity == null)
            {
                return NotFound();
            }

            return recordActivity;
        }
        
        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<RecordActivity>> Post(RecordActivity value)
        {
            value.Time = DateTime.Now.ToString("MM/dd/yyyy H:mm:ss");
            _context.RecordActivities.Add(value);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = value.Id }, value);
        }
        /*
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
