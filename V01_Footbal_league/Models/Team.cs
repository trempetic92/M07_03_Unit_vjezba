﻿namespace V01_Footbal_league.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateEstablished { get; set; }
        public int LeagueId { get; set; }
    }
}
