using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BlanketApp.Data;
using System;
using System.Linq;
namespace BlanketApp.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BlanketAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BlanketAppContext>>()))
            {
                // Look for any movies.
                if (context.Blanket.Any())
                {
                    return;   // DB has been seeded
                }

                context.Blanket.AddRange(
                    new Blanket
                    {
                        Title = "Push Comforter Hometrends",
                        Material = "Fleece bed",
                        Type = "single",
                        Color = "Red",
                        Price = 10
                    },

                    new Blanket
                    {
                        Title = "Cuddly Blankets",
                        Material = "Sherpa",
                        Type = "Double bed",
                        Color = "green",
                        Price = 15
                    },

                    new Blanket
                    {
                        Title = "Dream Soft Blankets",
                        Material = "acrylics",
                        Type = "single bed",
                        Color = "Blue",
                        Price = 14
                    },

                    new Blanket
                    {
                        Title = "Parachute Blankets",
                        Material = "polyster",
                        Type = "single, Double",
                        Color = "White",
                        Price = 27
                    },
                    new Blanket
                    {
                        Title = "Soothing Covers",
                        Material = "Cotton",
                        Type = "single, Double",
                        Color = "Purpal",
                        Price = 20
                    },
                    new Blanket
                    {
                        Title = "Heaven Sent Blankets",
                        Material = "Wool",
                        Type = "single",
                        Color = "Black",
                        Price = 30
                    },
                    new Blanket
                    {
                        Title = "Snuggly Blankets",
                        Material = "polyster",
                        Type = "Double Bed",
                        Color = "Gray",
                        Price = 17
                    },
                    new Blanket
                    {
                        Title = "The Feather Factory",
                        Material = "Cotton",
                        Type = "single, Double",
                        Color = "Yellow",
                        Price = 28
                    },
                    new Blanket
                    {
                        Title = "Luxury Blankets",
                        Material = "Fleece",
                        Type = "single",
                        Color = "White",
                        Price = 23
                    },
                    new Blanket
                    {
                        Title = "Urban Blankets",
                        Material = "polyster",
                        Type = "Double",
                        Color = "Orange",
                        Price = 50
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
