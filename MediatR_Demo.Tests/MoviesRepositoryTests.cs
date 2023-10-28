using AutoFixture;
using FluentAssertions;
using MediatR_Demo.Core.Domain.Entities;
using MediatR_Demo.Core.Domain.ExtensionMethods;
using MediatR_Demo.Core.Domain.RepositoryContracts;
using Moq;

namespace MediatR_Demo.Tests
{
    public class MoviesRepositoryTests
    {
        private readonly IMovieDataAccess movieDataAccess;
        private readonly Mock<IMovieDataAccess> movieDataAccessMock;
        private readonly IFixture _fixture;
        public MoviesRepositoryTests()
        {
            movieDataAccessMock = new Mock<IMovieDataAccess>();
			movieDataAccess = movieDataAccessMock.Object;
			_fixture = new Fixture();
		}
        [Fact]
        public async Task GetMovies_Test()
        {
            List<Movie> moviesList = new List<Movie>()
            {
            _fixture.Build<Movie>().Create(),
            _fixture.Build<Movie>().Create(),
            _fixture.Build<Movie>().Create()
            };
            var movies_expected = moviesList.Select(temp=>temp.ToGetMovieDto()).ToList();
			movieDataAccessMock.Setup(temp => temp.GetMovies()).ReturnsAsync(moviesList);
            var allMovies_actual = await movieDataAccess.GetMovies();

            allMovies_actual.Should().BeEquivalentTo(moviesList);
        }
    }
}
