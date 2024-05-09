using V01_Footbal_league.Interfaces;
using V01_Footbal_league.Models;

namespace V01_Footbal_league.Repository
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly ITeamRepository _teamRepository;
        private readonly ILeagueRepository _leagueRepository;

        public PlayerRepository(ITeamRepository teamRepository, ILeagueRepository leagueRepository)
        {
            _leagueRepository = leagueRepository;
            _teamRepository = teamRepository;
        }
        public Player GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetForTeam(int teamId)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetForLeague(int leagueId)
        {
            var isLeagueValid = _leagueRepository.isValid(leagueId);

            if (isLeagueValid)
            {
                return new List<Player>();
            }

            List<Player> players = new List<Player>();
            var teams = _teamRepository.GetForLeague(leagueId);
            foreach (var team in teams)
            {
                players.AddRange(GetForTeam(team.Id));
            }

            return players;
        }
    }
}
