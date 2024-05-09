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
    public class MockPlayerRepository : Mock<IPlayerRepository>
    {
        public MockPlayerRepository MockGetById(Player result)
        {
            Setup(x => x.GetById(It.IsAny<int>())).Returns(result);
            return this;
        }

        public MockPlayerRepository MockGetByIdInvalid()
        {
            Setup(x => x.GetById(It.IsAny<int>())).Throws(new Exception("Nema tog ID-a"));
            return this;
        }

        public MockPlayerRepository VerifyGetById(Times times)
        {
            Verify(x => x.GetById(It.IsAny<int>()), times);
            return this;
        }

        public MockPlayerRepository MockGetForLEague(List<Player> results)
        {
            Setup(x => x.GetForLeague(It.IsAny<int>())).Returns(results);
            return this;
        }
    }
}
