using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Domain.DTO.Response
{
    public class CreateMovieDto
    {
        public CreateMovieDto(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }
}
