using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoLPower.Core.GameMonitor;
using LoLPower.Core.Riot;

namespace LoLPower.UI
{
    public partial class Form1 : Form
    {
        private GameMonitorWmiManager _gameMonitor;
        private RiotClient _riotClient;
        public Form1()
        {
            InitializeComponent();
            _riotClient = new RiotClient(ConfigurationManager.AppSettings["riotGamesApiKey"]);
            _gameMonitor = GameMonitorWmiManager.Instance("League Of Legends.exe");

            _gameMonitor.Started += gameMonitor_GameStart;
            _gameMonitor.Ended += gameMonitor_GameEnd;
        }

        private void gameMonitor_GameStart(object sender, EventArrivedEventArgs args)
        {
            lblStatusMessage.Text = $"Started...";
        }

        private void gameMonitor_GameEnd(object sender, EventArrivedEventArgs args)
        {
            lblStatusMessage.Text = $"Ended...";
        }

        private async void btntest_Click(object sender, EventArgs e)
        {
            try
            {
                var test = await _riotClient.GetCurrentlyPlayedGameForSummonerAsync("freakpeach");
                var x = test;
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
