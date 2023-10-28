using MediatR_Demo.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Application.Movies.Commands.CreateMovie
{
    public static class CreateMovieCommandExtension
    {
        public static Movie CreateMovie(this CreateMovieCommand command)
        {
            var movie = new Movie()
            {
                Title = command.Title,
                Description = command.Description,
                Rating = command.Rating,
                Genre = command.MovieGenre
            };
            return movie;
        }
    }
}
