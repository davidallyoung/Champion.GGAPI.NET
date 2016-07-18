using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Champion.GGAPI.ClientModels
{
    public class ChampionDetailModel
    {
        public string key { get; set; }
        public string role { get; set; }
        public OverallPosition overallPosition { get; set; }
        public Items items { get; set; }
        public FirstItems firstItems { get; set; }
        public List<double> championMatrix { get; set; }
        public List<Trinket> trinkets { get; set; }
        public Summoners summoners { get; set; }
        public Runes runes { get; set; }
        public List<double> experienceRate { get; set; }
        public List<double> experienceSample { get; set; }
        public List<double> patchWin { get; set; }
        public List<double> patchPlay { get; set; }
        public DmgComposition dmgComposition { get; set; }
        public List<Matchup> matchups { get; set; }
        public General general { get; set; }
        public Skills skills { get; set; }
        public Masteries masteries { get; set; }
        public class OverallPosition
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class Item
        {
            public int id { get; set; }
            public string name { get; set; }
        }

        public class MostGames
        {
            public List<Item> items { get; set; }
            public double winPercent { get; set; }
            public int games { get; set; }
        }

        public class HighestWinPercent
        {
            public List<Item> items { get; set; }
            public double winPercent { get; set; }
            public int games { get; set; }
        }

        public class Items
        {
            public MostGames mostGames { get; set; }
            public HighestWinPercent highestWinPercent { get; set; }
        }

        public class FirstItems
        {
            public MostGames mostGames { get; set; }
            public HighestWinPercent highestWinPercent { get; set; }
        }

        public class Trinket
        {
            public int games { get; set; }
            public double winPercent { get; set; }
            public Item item { get; set; }
        }

        public class Summoner
        {
            public string name { get; set; }
        }

        public class SummonerMostGames
        {
            public Summoner summoner1 { get; set; }
            public Summoner summoner2 { get; set; }
            public double winPercent { get; set; }
            public int games { get; set; }
        }

        public class SummonersWinPercent
        {
            public Summoner summoner1 { get; set; }
            public Summoner summoner2 { get; set; }
            public double winPercent { get; set; }
            public int games { get; set; }
        }

        public class Summoners
        {
            public SummonerMostGames mostGames { get; set; }
            public SummonersWinPercent highestWinPercent { get; set; }
        }

        public class Rune
        {
            public int id { get; set; }
            public int number { get; set; }
            public string name { get; set; }
            public string description { get; set; }
        }

        public class MostGamesRunes
        {
            public List<Rune> runes { get; set; }
            public double winPercent { get; set; }
            public int games { get; set; }
        }

        public class HighestWinPercentRunes
        {
            public List<Rune> runes { get; set; }
            public double winPercent { get; set; }
            public int games { get; set; }
        }

        public class Runes
        {
            public MostGamesRunes mostGames { get; set; }
            public HighestWinPercentRunes highestWinPercent { get; set; }
        }

        public class DmgComposition
        {
            public double trueDmg { get; set; }
            public double magicDmg { get; set; }
            public double physicalDmg { get; set; }
        }

        public class Matchup
        {
            public int games { get; set; }
            public double statScore { get; set; }
            public double winRate { get; set; }
            public double winRateChange { get; set; }
            public string key { get; set; }
        }

        public class WinPercent
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class PlayPercent
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class BanRate
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class Experience
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class GoldEarned
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class Kills
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class Deaths
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class Assists
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class TotalDamageDealtToChampions
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class LargestKillingSpree
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class MinionsKilled
        {
            public int change { get; set; }
            public int position { get; set; }
        }

        public class General
        {
            public WinPercent winPercent { get; set; }
            public PlayPercent playPercent { get; set; }
            public BanRate banRate { get; set; }
            public Experience experience { get; set; }
            public GoldEarned goldEarned { get; set; }
            public Kills kills { get; set; }
            public Deaths deaths { get; set; }
            public Assists assists { get; set; }
            public TotalDamageDealtToChampions totalDamageDealtToChampions { get; set; }
            public LargestKillingSpree largestKillingSpree { get; set; }
            public MinionsKilled minionsKilled { get; set; }
        }

        public class SkillInfo
        {
            public string name { get; set; }
            public string key { get; set; }
        }

        public class MostGames5
        {
            public List<string> order { get; set; }
            public double winPercent { get; set; }
            public int games { get; set; }
        }

        public class HighestWinPercentSkills
        {
            public List<string> order { get; set; }
            public double winPercent { get; set; }
            public int games { get; set; }
        }

        public class Skills
        {
            public List<SkillInfo> skillInfo { get; set; }
            public MostGames5 mostGames { get; set; }
            public HighestWinPercentSkills highestWinPercent { get; set; }
        }

        public class Datum
        {
            public int points { get; set; }
            public int? mastery { get; set; }
        }

        public class Mastery
        {
            public string tree { get; set; }
            public int total { get; set; }
            public List<Datum> data { get; set; }
        }

        public class MostGamesMasteries
        {
            public double winPercent { get; set; }
            public int games { get; set; }
            public List<Mastery> masteries { get; set; }
        }

        public class HighestWinPercentMesteries
        {
            public double winPercent { get; set; }
            public int games { get; set; }
            public List<Mastery> masteries { get; set; }
        }

        public class Masteries
        {
            public MostGamesMasteries mostGames { get; set; }
            public HighestWinPercentMesteries highestWinPercent { get; set; }
        }
    }
}
