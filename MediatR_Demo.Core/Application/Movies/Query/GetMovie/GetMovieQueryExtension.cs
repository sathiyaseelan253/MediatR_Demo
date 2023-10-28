using MediatR_Demo.Core.Domain.DTO.Response;
using MediatR_Demo.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Application.Movies.Query.GetMovie
{
    public static class GetMovieQueryExtension
    {
        public static GetMovieDTO MapTo(this Movie movie)
        {
            return new GetMovieDTO
            {
                Id = movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Rating = movie.Rating,
                Genre = movie.Genre,
            };
        }
    }
}
