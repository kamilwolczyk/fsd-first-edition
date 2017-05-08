using Fsd.Cs.Data.Entities;
using System.Collections.Generic;

namespace Fsd.Cs.Services
{
    public interface ITeamService
    {
        IEnumerable<FootballTeam> GetAllTeams();

        FootballTeam GetById(int id);

        void AddNewTeam(string name, int foundationYear);
    }
}
