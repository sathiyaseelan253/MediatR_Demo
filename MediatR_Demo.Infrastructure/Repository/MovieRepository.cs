using MediatR_Demo.Core.Domain.DTO.Request.Movie;
using MediatR_Demo.Core.Domain.DTO.Response;
using MediatR_Demo.Core.Domain.Entities;
using MediatR_Demo.Core.Domain.RepositoryContracts;
using MediatR_Demo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace MediatR_Demo.Infrastructure.Repository
{
    public class MovieRepository : IMovieDataAccess
    {
        private readonly ApplicationDBContext _db;
        public MovieRepository(ApplicationDBContext db)
        {
            _db = db;
        }


        public async Task<CreateMovieDto> CreateMovie(Movie createMovieRequest)
        {
            
            await _db.Movies.AddAsync(createMovieRequest);
            await _db.SaveChangesAsync();
            return new CreateMovieDto(createMovieRequest.Id);
        }

        public async Task<List<Movie>> GetMovies()
        {
            return await _db.Movies.ToListAsync();
        }
        public async Task<Movie> GetMovieByID(long id)
        {
            return await _db.Movies.Where(temp=>temp.Id == id).FirstOrDefaultAsync();
        }

    }
}
