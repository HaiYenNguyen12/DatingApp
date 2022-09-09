
using DatingApp.API.Database;
using DatingApp.API.Database.entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : BaseApiController
    {
        private readonly DataContext _context;
        public SongController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Song>>>  GetSongs()
        {
            return Ok(await _context.Songs.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult<List<Song>>> CreateSong(Song song)
        {
            _context.Songs.Add(song);
            await _context.SaveChangesAsync();
            return Ok(await _context.Songs.ToListAsync());
        
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<Song>>>  GetSong(int id)
        {
            var song = _context.Songs.FirstOrDefaultAsync(u => u.Id == id);
            if (song == null) {
                return NotFound("This song doesn't exist.");
            }
            return Ok(song);

            // return Ok(await _context.Songs.ToListAsync());
        }

    }
}