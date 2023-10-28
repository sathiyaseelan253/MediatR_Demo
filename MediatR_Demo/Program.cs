using MediatR;
using MediatR_Demo.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using MediatR_Demo.Core.Application.Movies.Commands.CreateMovie;
using MediatR_Demo.Core.Domain.RepositoryContracts;
using MediatR_Demo.Infrastructure.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationDBContext>(
        options=>options.UseSqlServer(builder.Configuration.GetConnectionString("defaultConnectionString"))
    );
var cqrsClass = typeof(CreateMovieCommand);
builder.Services.AddMediatR(cqrsClass.Assembly);
builder.Services.AddScoped<IMovieDataAccess, MovieRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
