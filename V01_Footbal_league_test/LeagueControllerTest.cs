using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V01_Footbal_league.Controllers;
using V01_Footbal_league.Models;
using V01_Footbal_league_test.Mock;
using Moq;

namespace V01_Footbal_league_test
{
    public class LeagueControllerTest
    {
        [Fact]
        public void LeagueController_Index_LeaguesExists()
        {
            var mockLeagues = new List<League>()
            {
                new League()
                {
                    Id = 1,
                    DateEstablished = new DateTime(2000,3,25)
                }
            };

            var mockLeagueRepository = new MockLeagueRepository().MockGetAll(mockLeagues);
            var controller = new LeagueController(mockLeagueRepository.Object);

            var result = controller.Index();

            Assert.IsAssignableFrom<ViewResult>(result);
            mockLeagueRepository.VerifyGetAll(Times.Once());
        }

        [Fact]
        public void LeagueController_Index_noLeagues()
        {
            var mockLeagues = new List<League>()
            {
                new League()
                {
                    Id = 1,
                    DateEstablished = new DateTime(2000,3,25)
                }
            };

            var mockLeagueRepository = new MockLeagueRepository().MockGetAll(new List<League>);
            var controller = new LeagueController(mockLeagueRepository.Object);

            var result = controller.Index();

            Assert.IsAssignableFrom<ViewResult>(result);
            mockLeagueRepository.VerifyGetAll(Times.Once());
        }


    }
}
