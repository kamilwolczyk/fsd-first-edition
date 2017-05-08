using Fsd.Cs.Data.Entities;
using System.Data.Entity;

namespace Fsd.Cs.Data
{
    public class FootballDb : DbContext
    {
        public DbSet<FootballTeam> FootballTeams { get; set; }

        public DbSet<Player> Players { get; set; }

        public FootballDb() : base("football")
        { }
    }
}
