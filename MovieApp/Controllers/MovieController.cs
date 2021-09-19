using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;
using MovieApp.Services;
namespace MovieApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        IMovieRepository iMovieRepository;
        public MovieController(IMovieRepository _iMovieRepository)
        {
            iMovieRepository = _iMovieRepository;
        }

        [HttpPost]
        [Route("addMovie")]
        public IActionResult AddRecord(Movies movies)
        {
            iMovieRepository.AddMovie(movies);
            return Ok("Record Added!!!");
        }

        [HttpDelete]
        [Route("deleteMovie/{mName}")]
        public IActionResult DeleteRecord(string mName)
        {
            var delObj = iMovieRepository.DeleteMovie(mName);
            if(delObj != 0)
            {
                return Ok("Record Deleted !!!");
            }
            return BadRequest();
        }

        [HttpGet]
        [Route("searchMovie/{mName}")]
        public IActionResult SearchRrcord(string mName)
        {
            var seObj = iMovieRepository.SearchMovies(mName);
            if(seObj != null)
            {
                return Ok(seObj);
            }
            return BadRequest();
        }
        
        [HttpPut]
        [Route("updateMovie/{mName}")]
        public IActionResult UpdateRecord(Movies movies)
        {
            var updObj=iMovieRepository.UpdateMovie(movies);
            if(updObj != 0)
            {
                return Ok("Record Updated");
            }
            return BadRequest();
        }
        
        [HttpGet]
        [Route("showAllMovies")]
        public IActionResult GetAllRecords()
        {
            var getObj = iMovieRepository.GetAllMovies();
            return Ok(getObj);
        }
        
    }
}