using V01_Footbal_league.Models;

namespace V01_Footbal_league.Interfaces
{
    public interface ITeamRepository
    {
        Team GetById(int id);
        List<Team> GetForLeague(int leagueId);
        List<Team> Search(TeamSearch teamSearch);

    }
}
