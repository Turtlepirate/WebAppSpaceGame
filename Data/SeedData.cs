using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace WebAppSpaceGame.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebAppSpaceGameContext(
                serviceProvider.GetRequiredService<DbContextOptions<WebAppSpaceGameContext>>()))
            {
                // Look for any movies.
                if (context.Good.Any())
                {
                    return;   // DB has been seeded
                }

                context.Good.AddRange(
                     new Good
                     {
                         ID = 1,
                         Name = "Test",
                         FromDate = DateTime.Parse("1989-1-11"),
                         Rarity = "Common",
                         Price = 20
                     },

                      new Good
                      {
                          ID = 2,
                          Name = "Food",
                          FromDate = DateTime.Parse("1989-1-11"),
                          Rarity = "Abundant",
                          Price = 3
                      },

                      new Good
                      {
                          ID = 3,
                          Name = "Coal",
                          FromDate = DateTime.Parse("1989-1-11"),
                          Rarity = "Abundant",
                          Price = 30
                      },

                    new Good
                    {
                        ID = 4,
                        Name = "Iron",
                        FromDate = DateTime.Parse("1989-1-11"),
                        Rarity = "Average",
                        Price = 202
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
