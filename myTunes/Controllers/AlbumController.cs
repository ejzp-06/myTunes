using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using myTunes.Interfaces;
using myTunes.Core.Entities;
using myTunes.Core.Enums;

namespace myTunes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Album>> Get()
        {
            var serviceResult = _albumService.GetAlbums();
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);

            return Ok(serviceResult.Result.Select(a => new Album
            {
                Id = a.Id,
                Name = a.Name,
                Author = a.Author,
                Genre = a.Genre,
                Description = a.Description,
                points = a.points,
                Price = a.Price,
                Image = a.Image,
                LaunchDate = a.LaunchDate,
                Songs = a.Songs
            }));
        }

        [HttpGet]
        [Route("album/{Id}")]
        public ActionResult<Album> Get(int albumId)
        {
            var serviceResult = _albumService.GetAlbumById(albumId);
            if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);

            var album = serviceResult.Result;
            return Ok(new Album
            {
                Id = album.Id,
                Name = album.Name,
                Author = album.Author,
                Genre = album.Genre,
                Description = album.Description,
                points = album.points,
                Price = album.Price,
                Image = album.Image,
                LaunchDate = album.LaunchDate,
                Songs = album.Songs
            });
        }
    }
}
