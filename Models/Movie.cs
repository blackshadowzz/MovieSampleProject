﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MovieSampleProject.Models
{
    //Movie Model
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Column(TypeName = ("varchar(30)"))]
        public string? Languege { get; set; }

        public MovieType? MovieType { get; set; }
        [Column(TypeName = ("decimal(18,2)"))]
        public decimal? Budget { get; set; }
        [Column(TypeName = ("varchar(500)"))]
        public string? Description { get; set; }
        public DateTime? Released { get; set; }
        [Column(TypeName = ("varchar(30)"))]
        public string? Duration { get; set; }
        [Column(TypeName = ("nvarchar(30)"))]
        public string? Country { get; set; }
        [Column(TypeName = ("varchar(40)"))]
        public string? Production { get; set; }
        public int? AgeLimited { get; set; }
    }

    //Movie Type
    public enum MovieType
    {
        Action,
        Horror,
        Biography,
        Drama,
        Sci_Fi_x_Fantasy,
        Science_Fiction,
        TV_Movie,
        Comedy,
        War,
        Family,
        Animation,
        Anime,
        Adventure,
        Crime,
        Romantic,
        History,
        Thriller

    }
}
