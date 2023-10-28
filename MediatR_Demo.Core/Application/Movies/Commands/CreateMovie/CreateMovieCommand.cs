using MediatR;
using MediatR_Demo.Core.Domain.DTO.Response;
using MediatR_Demo.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Application.Movies.Commands.CreateMovie
{
    public class CreateMovieCommand : IRequest<CreateMovieDto>
    {
        public CreateMovieCommand(string? title,string? description,MovieGenre movieGenre, int? rating )
        {
            Title = title;
            Description = description;
            MovieGenre = movieGenre;
            Rating = rating;
        }

        public string? Title { get; }
        public string? Description { get; }
        public MovieGenre MovieGenre { get; }
        public int? Rating { get; }
    }
}
