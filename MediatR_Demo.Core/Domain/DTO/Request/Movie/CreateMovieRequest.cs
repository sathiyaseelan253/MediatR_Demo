using MediatR_Demo.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Domain.DTO.Request.Movie
{
    public class CreateMovieRequest
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public MovieGenre Genre { get; set; }
        public int? Rating { get; set; }
    }
}
