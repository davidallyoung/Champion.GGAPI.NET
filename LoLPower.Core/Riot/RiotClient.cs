using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotSharp;
using RiotSharp.ChampionEndpoint;
using RiotSharp.CurrentGameEndpoint;

namespace LoLPower.Core.Riot
{
    public class RiotClient
    {
        private RiotApi _api;
        public RiotClient(string apiKey)
        {
           _api = RiotApi.GetInstance(apiKey);
        }

        public async Task<CurrentGame> GetCurrentlyPlayedGameForSummonerAsync(string summonerName)
        {
            var summoner = await _api.GetSummonerAsync(Region.na, summonerName);
            var currGame = await _api.GetCurrentGameAsync(Platform.NA1, summoner.Id);
            var champions = await _api.GetChampionsAsync(Region.na);

            return currGame;
        }
    }
}
