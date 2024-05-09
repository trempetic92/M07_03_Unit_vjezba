using V01_Footbal_league.Models;

namespace V01_Footbal_league.Interfaces
{
    public interface ILeagueRepository
    {
        League GetById(int id);
        List<League> GetAll();
        bool isValid(int leagueId);
    }
}
