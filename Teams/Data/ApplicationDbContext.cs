using Microsoft.EntityFrameworkCore;
using Teams.Models;

namespace Teams.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<InfoTeams> infoTeams { get; set; }
    }
}
