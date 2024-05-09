using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V01_Footbal_league.Controllers;
using V01_Footbal_league.Models;
using V01_Footbal_league_test.Mock;

namespace V01_Footbal_league_test
{
    public class TeamControllerTest
    {
        [Fact]
        public void TeamController_Search_Get_Valid()
        {
            var mockTeams = new List<Team>()
            {
                new Team
                {
                    Id = 1
                }
            };
            var mockTeamRepository = new MockTeamRepository().MockSearch(mockTeams);
            var controller = new TeamControler(mockTeamRepository.Object);
            var result = controller.Search();

            Assert.IsAssignableFrom<ViewResult>(result);
        }

        [Fact]
        public void TeamController_Search_Post_Valid()
        {
            var mockTeams = new List<Team>()
            {
                new Team
                {
                    Id = 1
                }
            };
            var mockTeamRepository = new MockTeamRepository().MockSearch(mockTeams);
            var controller = new TeamControler(mockTeamRepository.Object);
            var result = controller.Search(new TeamSearch());

            Assert.IsAssignableFrom<ViewResult>(result);
            mockTeamRepository.VerifySearch(Times.Once());
        }

        [Fact]
        public void TeamController_Search_Post_ModelStateInvalid()
        {
            var mockTeams = new List<Team>()
            {
                new Team
                {
                    Id = 1
                }
            };
            var mockTeamRepository = new MockTeamRepository().MockSearch(mockTeams);
            var controller = new TeamControler(mockTeamRepository.Object);
            controller.ModelState.AddModelError("Error", "Test");

            var result = controller.Search(new TeamSearch());

            Assert.IsAssignableFrom<ViewResult>(result);
            mockTeamRepository.VerifySearch(Times.Once());

            var redirectAtion = (RedirectToActionResult)result;
            Assert.Equal("Search", redirectAtion.ActionName);
        }
    }
}
