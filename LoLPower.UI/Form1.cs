using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoLPower.Core;
using LoLPower.Core.GameMonitor;
using LoLPower.Core.Riot;

namespace LoLPower.UI
{
    public partial class Form1 : Form
    {
        private readonly GameMonitorWmiManager _gameMonitor;
        private readonly RiotClient _riotClient;
        private const string SummonerName = "freakpeach";
        private readonly Progress<IProgressUpdate> _progressUpdater; 
        public Form1()
        {
            InitializeComponent();
            _progressUpdater = new Progress<IProgressUpdate>(StatusUpdate);
            _riotClient = new RiotClient(ConfigurationManager.AppSettings["riotGamesApiKey"], _progressUpdater);
            _gameMonitor = GameMonitorWmiManager.Instance("League Of Legends.exe");

            _gameMonitor.Started += gameMonitor_GameStart;
            _gameMonitor.Ended += gameMonitor_GameEnd;
        }

        private async void gameMonitor_GameStart(object sender, EventArrivedEventArgs args)
        {
            StatusUpdate(new ProgressUpdateDefault("Game Start Detected..."));
            await LoadGridWithCurrentGameData();
        }

        private void gameMonitor_GameEnd(object sender, EventArrivedEventArgs args)
        {
            StatusUpdate(new ProgressUpdateDefault("Game End Detected..."));
        }

        private async void btntest_Click(object sender, EventArgs e)
        {
            await LoadGridWithCurrentGameData();
        }

        private async Task LoadGridWithCurrentGameData()
        {
            try
            {
                var test = await _riotClient.GetCurrentlyPlayedGameForSummonerAsync("freakpeach");
                dgvCurrentPlayerIno.DataSource = test;
            }
            catch (Exception)
            {
                lblStatusMessage.Text = $"No current game information found for {SummonerName}";
                return;
            }
        }

        private void StatusUpdate(IProgressUpdate progressUpdate)
        {
            lblStatusMessage.Text = progressUpdate.Message;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _gameMonitor.Dispose();
        }
    }
}
