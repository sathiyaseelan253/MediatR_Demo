﻿using MediatR_Demo.Core.Enums;

namespace MediatR_Demo.Core.Domain.Entities
{
    public class Movie
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public MovieGenre Genre { get; set; }
        public int? Rating { get; set; }
    }
}
