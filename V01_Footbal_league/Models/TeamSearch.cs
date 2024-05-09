using System.ComponentModel.DataAnnotations;

namespace V01_Footbal_league.Models
{
    public enum SearchDateDirection
    {
        OlderThan,
        NewerThan
    }
    public class TeamSearch
    {
        [Required]
        [Range(1 , 500)]
        public int LeagueId { get; set; }
        public DateTime DateStablished { get; set; }
        public SearchDateDirection Direction { get; set; }
        public List<Team> Results { get; set;}
    }
}
