using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppSpaceGame.Models
{
    public class WebAppSpaceGameContext : DbContext
    {
        public WebAppSpaceGameContext (DbContextOptions<WebAppSpaceGameContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppSpaceGame.Models.Good> Good { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Good>().ToTable("Good");
          
        }
    }
}
