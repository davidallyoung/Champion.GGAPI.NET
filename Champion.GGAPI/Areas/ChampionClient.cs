using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Champion.GGAPI.ClientModels;
using Champion.GGAPI.Web;

namespace Champion.GGAPI.Areas
{
    public class ChampionClient
    {
        private readonly string _apiKey;
        public ChampionClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public async Task<List<AllChampionsModel>> GetAllChampionsAsync()
        {
            var apiCall = $"champion?api_key={_apiKey}";
            var champions = await ChampionGgCallerHttpClient.CallChampionGgApiAsync<List<AllChampionsModel>>(apiCall).ConfigureAwait(false);
            return champions;
        } 
    }
}
