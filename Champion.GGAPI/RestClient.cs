using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Champion.GGAPI.Areas;

namespace Champion.GGAPI
{
    public class RestClient
    {
        public ChampionClient ChampionClient { get; set; }

        private string _apiKey;
        public RestClient(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey)) { throw new ArgumentNullException(nameof(apiKey));}

            _apiKey = apiKey;

            ChampionClient = new ChampionClient(apiKey);
        }


    }
}
