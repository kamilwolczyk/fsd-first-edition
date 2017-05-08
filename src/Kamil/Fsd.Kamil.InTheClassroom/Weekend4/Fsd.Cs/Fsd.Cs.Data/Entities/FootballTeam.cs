using System.Collections.Generic;

namespace Fsd.Cs.Data.Entities
{
    public class FootballTeam
    {
        public FootballTeam()
        {
            Players = new List<Player>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int FoundationYear { get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}
