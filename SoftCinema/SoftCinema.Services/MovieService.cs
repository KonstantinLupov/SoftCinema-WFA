﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using SoftCinema.Data;
using SoftCinema.Models;

namespace SoftCinema.Services
{
    public static class MovieService
    {
        public static void AddMovie(string movieName, float? rating, int length, string directorName, int releaseYear,
            AgeRestriction ageRestriction, string synopsis, string releaseCountry, byte[] image)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Movie movie = new Movie()
                {
                    Name = movieName,
                    Rating = rating,
                    Length = length,
                    DirectorName = directorName,
                    ReleaseYear = releaseYear,
                    ReleaseCountry = releaseCountry,
                    AgeRestriction = ageRestriction,
                    Synopsis = synopsis,
                    Image = new Image() {Content = image}
                };
                context.Movies.Add( movie);
                context.SaveChanges();
            }
        }

        public static void AddCategoryToMovie(string categoryName, string movieName, int releaseYear)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                Movie movie = context.Movies.First(m => m.Name == movieName && m.ReleaseYear == releaseYear);
                Category category = context.Categories.First(c => c.Name == categoryName);
                movie.Categories.Add(category);
                context.SaveChanges();
            }
        }

        public static int GetMovieId(string movieName, int releaseYear)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Movies.First(m => m.Name == movieName && m.ReleaseYear == releaseYear).Id;
            }
        }

        public static List<Movie> GetAllMovies()
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context
                    .Movies
                    .Include("Image")
                    .ToList();
            }
        }

        public static ICollection<Movie> GetMoviesByCinemaAndTown(string cinemaName, string townName)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context
                    .Screenings
                    .Where(s => s.Auditorium.Cinema.Name == cinemaName && s.Auditorium.Cinema.Town.Name == townName)
//                    .Include("Movie")
                    .Select(s => s.Movie)
                    .Distinct()
                    .ToList();
            }
        }

        public static string[] GetMoviesNameAndYearAsString()
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {

                List<string> result = new List<string>();
                foreach (var m in context.Movies)
                {

                    result.Add($"{m.Name},{m.ReleaseYear}");

                }
                return result.ToArray();

            }
        }

        public static Movie GetMovieByYearAndName(int movieYear, string movieName)
        {

            using (var db = new SoftCinemaContext())
            {
                return db.Movies
                    .Include("Image")
                    .Include("Categories")
                    .Include("Cast")
                    .FirstOrDefault(m => m.Name == movieName && m.ReleaseYear == movieYear);
            }
        }

        public static Movie GetMovie(string movieName)
        {
            using (var db = new SoftCinemaContext())
            {
                return db.Movies
                    .Include("Image")
                    .Include("Categories")
                    .Include("Cast")
                    .FirstOrDefault(m => m.Name == movieName);
            }
        }

        public static bool IsMovieExisting(string movieName, int releaseYear)
        {
            using (SoftCinemaContext context = new SoftCinemaContext())
            {
                return context.Movies.Any(m => m.Name == movieName && m.ReleaseYear == releaseYear);
            }
        }


        
    }
}