using MediatR_Demo.Core.Domain.Entities;
using MediatR_Demo.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Domain.DTO.Response
{
    public class GetMovieDTO
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public MovieGenre? Genre { get; set; }
        public int? Rating { get; set; }
       
    }
}
