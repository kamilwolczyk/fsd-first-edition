using Fsd.Cs.Data.Entities;
using Fsd.Cs.Services;
using Fsd.Cs.Web.Models;
using System.Linq;
using System.Web.Mvc;

namespace Fsd.Cs.Web.Controllers
{
    public class TeamController : Controller
    {
        private ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public ActionResult List()
        {
            FootballTeamListModel model = new FootballTeamListModel
            {
                Teams = _teamService.GetAllTeams().Select(MapTeamToModel)
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int teamId)
        {
            FootballTeam team = _teamService.GetById(teamId);

            return View(MapTeamToModel(team));
        }

        [HttpPost]
        public ActionResult Edit(FootballTeamModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            //todo: save in the db
            
            return RedirectToAction("SaveSuccess");
        }

        [HttpGet]
        public ActionResult SaveSuccess()
        {
            return View();
        }

        private FootballTeamModel MapTeamToModel(FootballTeam entity)
        {
            return new FootballTeamModel
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}