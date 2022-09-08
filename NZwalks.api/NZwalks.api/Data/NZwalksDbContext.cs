using Microsoft.EntityFrameworkCore;
using NZwalks.api.Models.Domain;

namespace NZwalks.api.Data
{
    public class NZwalksDbContext: DbContext
    {
        public NZwalksDbContext(DbContextOptions<NZwalksDbContext> options):base(options)
            { 
        
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDificulty> WalkDificulty { get; set; }


    }
}
