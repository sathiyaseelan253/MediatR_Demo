using MediatR;
using MediatR_Demo.Core.Domain.DTO.Response;
using MediatR_Demo.Core.Domain.Entities;
using MediatR_Demo.Core.Domain.RepositoryContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Application.Movies.Query.GetMovie
{
    public class GetMovieQueryHandler : IRequestHandler<GetMovieQuery, GetMovieDTO>
    {
        private readonly IMovieDataAccess _db;

        public GetMovieQueryHandler(IMovieDataAccess movieDataAccess)
        {
            this._db = movieDataAccess;
        }
        public async Task<GetMovieDTO> Handle(GetMovieQuery request, CancellationToken cancellationToken)
        {
            var movie= await this._db.GetMovieByID(request.id);
            var requiredResultDTO = movie.MapTo();
            return requiredResultDTO;
        }
    }
}
