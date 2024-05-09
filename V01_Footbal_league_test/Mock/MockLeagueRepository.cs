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
    public class MockLeagueRepository :Mock<ILeagueRepository>
    {
        public MockLeagueRepository MockGetAll(List<League> results)
        {
            Setup(x => x.GetAll()).Returns(results);
            return this;
        }
    }
}
