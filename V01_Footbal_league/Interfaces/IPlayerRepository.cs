using V01_Footbal_league.Models;

namespace V01_Footbal_league.Interfaces
{
    public interface IPlayerRepository
    {
        Player GetById(int id);
        List<Player> GetForTeam(int teamId);
        List<Player> GetForLeague(int leagueId);
    }
}
