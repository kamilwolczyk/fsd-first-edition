using Fsd.Cs.Services;
using Fsd.Cs.Web.Models;
using System.Linq;
using System.Web.Http;

namespace Fsd.Cs.Web.Controllers.Api
{
    [Route("api/teams")]
    public class TeamApiController : ApiController
    {
        private ITeamService _teamService;

        public TeamApiController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        
        [HttpGet]
        public FootballTeamListModel All()
        {
            return new FootballTeamListModel
            {
                Teams = _teamService.GetAllTeams().ToList().Select(entity=>new FootballTeamModel
                {
                    Id = entity.Id,
                    Name = entity.Name
                })
            };
        }
    }
}
