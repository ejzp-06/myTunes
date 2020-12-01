using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myTunes.Infrastructure;
using myTunes.Core.Entities;


namespace myTunes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly myTunesDbContext _myTunesDbContext;

        public SongController(IHttpContextAccessor httpContextAccessor, myTunesDbContext myTunesDbContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _myTunesDbContext = myTunesDbContext;
        }

        [HttpGet]
        public ActionResult<Song> Get()
        {
            var songId = _httpContextAccessor.HttpContext.Request.Headers["#Id"].ToString();
            var song = _myTunesDbContext.Songs.FirstOrDefault(b => b.Id.ToString() == songId);
            if (song == null)
            {
                return NotFound("El autor no existe.");
            }

            return Ok(new Song
            {
                Id = song.Id,
                Name = song.Name,
                Author = song.Author,
                Duration = song.Duration,
                Popularity = song.Popularity,
                Price = song.Price
                
            });
        }

        [HttpGet]
        [Route("{id}/songs")]
        public ActionResult<IEnumerable<Song>> Get([FromQuery] int id)
        {
            var list = _myTunesDbContext.Songs.Where(s => s.Id == id);
            return Ok(list.Select(s => new Song
            {
                Id = s.Id,
                Name = s.Name,
                Author = s.Author,
                Duration = s.Duration,
                Popularity = s.Popularity,
                Price = s.Price
            }));
        }
    }
}
