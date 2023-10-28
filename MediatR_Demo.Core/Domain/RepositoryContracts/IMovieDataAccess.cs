using MediatR_Demo.Core.Domain.DTO.Request.Movie;
using MediatR_Demo.Core.Domain.DTO.Response;
using MediatR_Demo.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Domain.RepositoryContracts
{
    public interface IMovieDataAccess
    {
        Task<List<Movie>> GetMovies();
        Task<CreateMovieDto> CreateMovie(Movie movie);
        Task<Movie> GetMovieByID(long id);
    }
}
