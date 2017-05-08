using Fsd.Cs.Data.Entities;
using Fsd.Cs.Services;
using Fsd.Cs.Web.Models;
using System.Collections.Generic;
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
                Teams = _teamService.GetAllTeams().ToList().Select(MapTeamToModel)
            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(int teamId)
        {
            FootballTeam team = _teamService.GetById(teamId);
            return View(MapTeamToModelWithPlayers(team));
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

        [HttpGet]
        public string AddNewTeam(string name, int year)
        {
            _teamService.AddNewTeam(name, year);
            return "OK";
        }

        private FootballTeamModel MapTeamToModel(FootballTeam entity)
        {
            return new FootballTeamModel
            {
                Id = entity.Id,
                Name = entity.Name,
                PlayerNames = new List<string>()
            };
        }

        private FootballTeamModel MapTeamToModelWithPlayers(FootballTeam entity)
        {
            return new FootballTeamModel
            {
                Id = entity.Id,
                Name = entity.Name,
                PlayerNames = entity.Players.Select(player => $"{player.FirstName} {player.LastName}")
            };
        }
    }
}