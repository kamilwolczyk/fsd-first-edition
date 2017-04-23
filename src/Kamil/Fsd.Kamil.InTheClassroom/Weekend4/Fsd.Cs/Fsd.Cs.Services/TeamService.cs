using Fsd.Cs.Data.Entities;
using Fsd.Cs.Data.Sql;
using System.Collections.Generic;

namespace Fsd.Cs.Services
{
    public class TeamService : ITeamService
    {
        private Repository<FootballTeam> _teamRepository;

        public TeamService()
        {
            _teamRepository = new Repository<FootballTeam>("FootballTeams", "Id", reader => new FootballTeam
            {
                Id = (int)reader["Id"],
                Name = (string)reader["Name"]
            });
        }

        public IEnumerable<FootballTeam> GetAllTeams()
        {
            return _teamRepository.GetAllData();
        }

        public FootballTeam GetById(int id)
        {
            return _teamRepository.GetById(id);
        }
    }
}
