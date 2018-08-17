using Microsoft.EntityFrameworkCore;
using Trinitron.Models;

namespace Trinitron.Persistence
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
        }

        public DbSet<Make> Makes { get; set; }
    }
}
