using V01_Footbal_league.Interfaces;
using V01_Footbal_league.Models;

namespace V01_Footbal_league.Repository
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ILeagueRepository _leagueRepository;

        public TeamRepository(ILeagueRepository leagueRepository)
        {
            _leagueRepository = leagueRepository;
        }
        public Team GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetForLeague(int leagueId)
        {
            throw new NotImplementedException();
        }

        public List<Team> Search(TeamSearch teamSearch)
        {
            // pretražujemo ligu koja nije valjana...
            var isLeagueValid = _leagueRepository.isValid(teamSearch.LeagueId);
            if (isLeagueValid)
            {
                return new List<Team>();
            }
            var teams = GetForLeague(teamSearch.LeagueId);

            if(teamSearch.Direction == SearchDateDirection.OlderThan)
            {
                return teams.Where(x => x.DateEstablished <= teamSearch.DateStablished).ToList(); 
            }
            else
            {
                return teams.Where(x => x.DateEstablished >= teamSearch.DateStablished).ToList();
            }
        }
    }
}
