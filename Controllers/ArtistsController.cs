using System;
using System.Collections.Generic;
using artist_api.Models;
using artist_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace artist_api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ArtistsController : ControllerBase
    {
        private readonly ArtistsService _artistsService;
        public ArtistsController(ArtistsService artistsService){
            _artistsService = artistsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Artist>> Get(){
            try
            {
                IEnumerable<Artist> artists = _artistsService.Get();
                return Ok(artists);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

         [HttpGet("{id}")]
        public ActionResult<Artist> Get(string id){
            try{
                Artist found = _artistsService.Get(id);
                return Ok(found);
            }catch (Exception err){
                return BadRequest(err.Message);
            }
        }

        [HttpPost]
        public ActionResult<Artist> Create([FromBody] Artist newArtist){
            try{
                Artist artist = _artistsService.Create(newArtist);
                return Ok(artist);
            } catch (Exception err) {
                return BadRequest(err.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<String> Delete(string id){
            try{
                _artistsService.Delete(id);
                return Ok("Successfully Deleted");
            }catch (Exception err){
                return BadRequest(err.Message);
            }
        }
    }
}