using Microsoft.AspNetCore.Mvc;
using V01_Footbal_league.Interfaces;

namespace V01_Footbal_league.Controllers
{
    public class LeagueController : Controller
    {
        private readonly ILeagueRepository _leagueRepository;
        public LeagueController(ILeagueRepository leagueRepository)
        {
            _leagueRepository = leagueRepository;
        }
        public IActionResult Index()
        {
            var leagues = _leagueRepository.GetAll();
            return View(leagues);
        }
    }
}
