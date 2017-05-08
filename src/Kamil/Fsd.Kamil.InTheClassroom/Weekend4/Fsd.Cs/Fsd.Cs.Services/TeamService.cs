using Fsd.Cs.Data;
using Fsd.Cs.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Fsd.Cs.Services
{
    public class TeamService : ITeamService
    {
        public FootballDb FootballDb { get; set; }

        public TeamService()
        {
            FootballDb = new FootballDb();
        }

        public IEnumerable<FootballTeam> GetAllTeams()
        {
            return FootballDb.FootballTeams;
        }

        public FootballTeam GetById(int id)
        {
            return FootballDb.FootballTeams.FirstOrDefault(item => item.Id == id);
        }

        public void AddNewTeam(string name, int foundationYear)
        {
            FootballTeam newTeam = new FootballTeam
            {
                Name = name,
                FoundationYear = foundationYear
            };

            FootballDb.FootballTeams.Add(newTeam);
            FootballDb.SaveChanges();
        }
    }
}
