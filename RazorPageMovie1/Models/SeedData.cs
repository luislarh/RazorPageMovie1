using Microsoft.EntityFrameworkCore;
using RazorPageMovie1.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace RazorPageMovie1.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageMovie1Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPageMovie1Context>>()))
            {
                if(context == null || context.Movie == null)
                {
                    throw new ArgumentException("Null RazorPageMovieContext");
                }
                //Para mirar cualquier pelicula
                if (context.Movie.Any())
                {
                    return; //Db muestra todo lo que contiene la clase
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "When Harry met sally",
                        ReleaseDate = DateTime.Parse("1980-12-12"),
                        Genre = "Comedia",
                        Price = 8.99M,
                        Rating = "R"

                    },
                    new Movie
                    {
                        Title = "Spiderman",
                        ReleaseDate = DateTime.Parse("2000-3-28"),
                        Genre = "Superheroes",
                        Price = 20M,
                        Rating = "G"

                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1980-1-23"),
                        Genre = "Action",
                        Price = 123.9M,
                        Rating = "G"

                    },
                    new Movie
                    {
                        Title = "Maze Runer",
                        ReleaseDate = DateTime.Parse("2007-5-20"),
                        Genre = "Action",
                        Price = 50M,
                        Rating = "NA"

                    },
                    new Movie
                    {
                        Title = "Shrek",
                        ReleaseDate = DateTime.Parse("2001-8-21"),
                        Genre = "Animada",
                        Price = 45M,
                        Rating = "G"

                    }
                    );
                context.SaveChanges();
            }
        }
        
    }
}
