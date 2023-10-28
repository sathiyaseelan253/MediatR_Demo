using MediatR;
using MediatR_Demo.Core.Domain.DTO.Response;
using MediatR_Demo.Core.Domain.Entities;
using MediatR_Demo.Core.Domain.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Application.Movies.Query.GetMovies
{
    public class GetMoviesQueryHandler : IRequestHandler<GetMoviesQuery, List<GetMovieDTO>>
    {
        private readonly IMovieDataAccess _db;

        public GetMoviesQueryHandler(IMovieDataAccess movieDataAccess)
        {
            this._db = movieDataAccess;
        }
        public async Task<List<GetMovieDTO>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
        {
            List<GetMovieDTO> getMovieDTOs = new List<GetMovieDTO>();
            List<Movie> allMovies = await _db.GetMovies();
            foreach (var movie in allMovies)
            {
                var movieDTO = movie.MapTo();
                getMovieDTOs.Add(movieDTO);
            }
            return getMovieDTOs;
        }
    }
}
