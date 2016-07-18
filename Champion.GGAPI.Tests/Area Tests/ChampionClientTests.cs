using System;
using System.Threading.Tasks;
using Champion.GGAPI.Areas;
using Champion.GGAPI.Exception;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Champion.GGAPI.Tests.Area_Tests
{
    [TestClass]
    public class ChampionClientTests
    {
        [TestMethod]
        public async Task ValidApiKey_IsSuccessful()
        {
            var client = new ChampionClient(TestApiInfo.ApiKey);
            var champions = await client.GetAllChampionsAsync().ConfigureAwait(false);

            Assert.IsNotNull(champions);
            Assert.IsTrue(champions.Count > 0);
        }

        [TestMethod]
        public async Task GetChampionDetails_IsSuccesful()
        {
            var client = new ChampionClient(TestApiInfo.ApiKey);
            var championDetails = await client.GetChampionDetails("Karma").ConfigureAwait(false);

            Assert.IsNotNull(championDetails);
            Assert.IsTrue(championDetails.Count == 2);
        }
    }
}
