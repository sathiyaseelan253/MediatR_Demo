using MediatR;
using MediatR_Demo.Core.Domain.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Application.Movies.Query.GetMovie
{
    public class GetMovieQuery : IRequest<GetMovieDTO>
    {
        public readonly long id;

        public GetMovieQuery(long id)
        {
            this.id = id;
        }
    }
}
