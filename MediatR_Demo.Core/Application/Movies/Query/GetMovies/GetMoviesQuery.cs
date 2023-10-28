using MediatR;
using MediatR_Demo.Core.Domain.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Application.Movies.Query.GetMovies
{
    public class GetMoviesQuery : IRequest<List<GetMovieDTO>>
    {
    }
}
