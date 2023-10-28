using MediatR_Demo.Core.Domain.DTO.Response;
using MediatR_Demo.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Demo.Core.Domain.ExtensionMethods
{
	public static class GetMovieExtension
	{
		public static GetMovieDTO ToGetMovieDto(this Movie movie)
		{
			return new GetMovieDTO { Id = movie.Id, Description = movie.Description, Genre = movie.Genre, Rating = movie.Rating };
		}
	}
}
