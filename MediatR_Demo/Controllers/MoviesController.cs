using MediatR;
using MediatR_Demo.Core.Application.Movies.Commands.CreateMovie;
using MediatR_Demo.Core.Application.Movies.Query.GetMovie;
using MediatR_Demo.Core.Application.Movies.Query.GetMovies;
using MediatR_Demo.Core.Domain.DTO.Request.Movie;
using Microsoft.AspNetCore.Mvc;

namespace MediatR_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator mediator;

        public MoviesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost("createMovie")]
        public async Task<ActionResult> CreateMovie([FromBody] CreateMovieRequest createMovieRequest)
        {
            try
            {
				var movie = await this.mediator.Send(new CreateMovieCommand(

				createMovieRequest.Title,
				createMovieRequest.Description,
				createMovieRequest.Genre,
				createMovieRequest.Rating
			));
				return Ok(movie);
			}
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpGet]
        public async Task<ActionResult> GetMovies()
        {
            try
            {
				var allMovies = await this.mediator.Send(new GetMoviesQuery());
				if (allMovies == null)
				{
					return NotFound("No movies in database. Please add a movie first.");
				}
				return Ok(allMovies);
			}
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
          
        }
        [HttpGet("getMovieByID/{id:int}")]
        public async Task<ActionResult> GetMovieByID(long id)
        {
            try
            {
				var fetchedMovie = await this.mediator.Send(new GetMovieQuery(id));
				if (fetchedMovie == null)
				{
					return NotFound($"No movie found in database with ID:{id}.");
				}
				return Ok(fetchedMovie);
			}
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }
    }
}
