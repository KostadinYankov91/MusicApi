using DotNetMusicApi.Modules;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetMusicApi.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    Id = 1,
                    Title = "Willow",
                    Language = "English",
                    Duration = "4:23"
                },
                new Song
                {
                    Id = 2,
                    Title = "Cemetery Gates",
                    Language = "English",
                    Duration = "4:23"
                }
                );
        }
    }
}
