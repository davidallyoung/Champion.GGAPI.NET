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
        private readonly RiotApi _api;
        private readonly IProgress<IProgressUpdate> _progressUpdater;
        public RiotClient(string apiKey, IProgress<IProgressUpdate> progressUpdater)
        {
            _api = RiotApi.GetInstance(apiKey);
            _progressUpdater = progressUpdater;
        }

        public async Task<CurrentGame> GetCurrentlyPlayedGameForSummonerAsync(string summonerName)
        {
            _progressUpdater.Report(new ProgressUpdateDefault("Retrieving Summonr Information..."));
            var summoner = await _api.GetSummonerAsync(Region.na, summonerName).ConfigureAwait(false);
            _progressUpdater.Report(new ProgressUpdateDefault("Retrieving current game information..."));
            var currGame = await _api.GetCurrentGameAsync(Platform.NA1, summoner.Id).ConfigureAwait(false);

            return currGame;
        }
    }
}
