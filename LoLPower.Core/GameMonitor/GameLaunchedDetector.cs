using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace LoLPower.Core.GameMonitor
{
    public class GameLaunchedDetector
    {
        private static GameLaunchedDetector _instance;
        private readonly ManagementEventWatcher _gameStartWatcher;
        private readonly ManagementEventWatcher _gameStopWatcher;

        private string GameStartQuery =
            "SELECT TargetInstance FROM __InstanceCreationEvent WITHIN 5 WHERE TargetInstance ISA 'Win32_Process' AND TargetInstance.Name LIKE '{0}'";

        private string EndStartQuery =
            "SELECT TargetInstance FROM __InstanceDeletionEvent WITHIN 5 WHERE TargetInstance ISA 'Win32_Process' AND TargetInstance.Name LIKE '{0}'";

        private GameLaunchedDetector(string gameProcessName)
        {
            _gameStartWatcher = new ManagementEventWatcher(string.Format(GameStartQuery, gameProcessName));
            _gameStopWatcher = new ManagementEventWatcher(string.Format(EndStartQuery, gameProcessName));

            _gameStartWatcher.EventArrived += GameStartedHandler;
            _gameStopWatcher.EventArrived += GameEndedHandler;
        }

        public static GameLaunchedDetector Instance(string gameProcessName)
        {
            return _instance ?? (_instance = new GameLaunchedDetector(gameProcessName));
        }

        private void GameStartedHandler(object sender, EventArrivedEventArgs args)
        {
            if (OnStarted != null)
            {
                OnStarted();
            }
        }

        private void GameEndedHandler(object sender, EventArrivedEventArgs args)
        {
            if (OnEnded != null)
            {
                OnEnded();
            }
        }

        public delegate void GameStartedEventHandler();
        public event GameStartedEventHandler OnStarted;

        public delegate void GameEndedEventHandler();
        public event GameEndedEventHandler OnEnded;
    }
}
