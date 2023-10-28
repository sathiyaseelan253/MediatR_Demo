using MediatR;
using MediatR_Demo.Core.Domain.DTO.Response;
using MediatR_Demo.Core.Domain.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Application.Movies.Commands.CreateMovie
{
    public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, CreateMovieDto>
    {
        private readonly IMovieDataAccess _movieDataAccess;
        public CreateMovieCommandHandler(IMovieDataAccess movieDataAccess)
        {
            _movieDataAccess = movieDataAccess;
        }


        public async Task<CreateMovieDto> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {
            var movie = request.CreateMovie();
            await _movieDataAccess.CreateMovie(movie);
            return new CreateMovieDto(movie.Id);
        }
    }
}
