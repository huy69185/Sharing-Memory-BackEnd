using MemorySharingAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MemorySharingAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Moment> Moments { get; set; }
    }
}
