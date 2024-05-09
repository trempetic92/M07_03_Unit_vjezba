using Microsoft.AspNetCore.Mvc;
using V01_Footbal_league.Interfaces;
using V01_Footbal_league.Models;

namespace V01_Footbal_league.Controllers
{
    public class TeamControler : Controller
    {
        private readonly ITeamRepository _teamRepository;
        public TeamControler(ITeamRepository teamRepository)
        {
            _teamRepository = teamRepository;
        }
        [HttpGet]
        public IActionResult Search()
        {
            var teamSearch = new TeamSearch();
            return View(teamSearch);
        }

        [HttpPost]
        public IActionResult Search(TeamSearch teamSearch)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Search");
            }

            var results = _teamRepository.Search(teamSearch);

            if (!results.Any())
            {
                return RedirectToAction("Search");
            }

            return View(results);

        }
    }
}
