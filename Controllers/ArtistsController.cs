using System.Collections.Generic;
using Artsy.Models;
using Artsy.Services;
using Microsoft.AspNetCore.Mvc;

namespace Artsy.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class ArtistsController : ControllerBase
    {
        private readonly ArtistsService _as;
        public ArtistsController(ArtistsService artistsService)
        {
            _as = artistsService;
        }

        [HttpGet]
        public ActionResult<List<Artist>> GetArtists()
        {
            try
            {
                Artist artists = _as.GetAll();
                return Ok(artists);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Artist> Get(string id)
        {
            try
            {
                Artist artists = _as.Get(id);
                return Ok(artists);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        public ActionResult<Artist> CreateArtist([FromBody] Artist artistData)
        {
            try
            {
                var artist = _as.CreateArtist(artistData);
                return Created($"api/artists/{artist.Id}", artist);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPut("{id}")]
        public ActionResult<Artist> Edit([FromBody] Artist updatedArtist, string id)
        {
            try
            {
                 updatedArtist.Id = id;
                 Artist artist = _artistsService.Edit(updatedArtist);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}