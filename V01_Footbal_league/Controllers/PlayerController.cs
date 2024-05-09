using Microsoft.AspNetCore.Mvc;
using V01_Footbal_league.Interfaces;

namespace V01_Footbal_league.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ITeamRepository _teamRepository;
        private readonly ILeagueRepository _leagueRepository;
        private readonly IPlayerRepository _playerRepository;

        public PlayerController(ITeamRepository teamRepository, ILeagueRepository leagueRepository, IPlayerRepository playerRepository)
        {
            _leagueRepository = leagueRepository;
            _teamRepository = teamRepository;
            _playerRepository = playerRepository;
        }
        public IActionResult Index(int id)
        {
            try
            {
                var player = _playerRepository.GetById(id);
                return View();
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error", "Home");
            }
        }

        public IActionResult League(int id)
        {
            if (!_leagueRepository.isValid(id))
            {
                return RedirectToAction("Error", "Home");
            }

            var players = _playerRepository.GetForLeague(id);
            return View(players);   
        }
    }
}
