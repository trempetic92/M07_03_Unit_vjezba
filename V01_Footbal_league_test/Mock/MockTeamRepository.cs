using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V01_Footbal_league.Interfaces;
using V01_Footbal_league.Models;

namespace V01_Footbal_league_test.Mock
{
    public class MockTeamRepository : Mock<ITeamRepository>
    {
        public MockTeamRepository MockSearch(List<Team> results)
        {
            Setup(x => x.Search(It.IsAny<TeamSearch>())).Returns(results);
            return this;
        }

        public MockTeamRepository VerifySearch (Times times)
        {
            Verify(x => x.Search(It.IsAny<TeamSearch>()),times);
            return this;
        }
    }
}
