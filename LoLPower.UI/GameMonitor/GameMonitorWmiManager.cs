using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using LoLPower.Core.Event;

namespace LoLPower.Core.GameMonitor
{
    public class GameMonitorWmiManager : IDisposable
    {
        private static GameMonitorWmiManager _instance;
        private readonly ManagementEventWatcher _gameStartWatcher;
        private readonly ManagementEventWatcher _gameStopWatcher;

        private string GameStartQuery =
            "SELECT TargetInstance FROM __InstanceCreationEvent WITHIN 5 WHERE TargetInstance ISA 'Win32_Process' AND TargetInstance.Name LIKE '{0}'";

        private string EndStartQuery =
            "SELECT TargetInstance FROM __InstanceDeletionEvent WITHIN 5 WHERE TargetInstance ISA 'Win32_Process' AND TargetInstance.Name LIKE '{0}'";

        private GameMonitorWmiManager(string gameProcessName)
        {
            _gameStartWatcher = new ManagementEventWatcher(string.Format(GameStartQuery, gameProcessName));
            _gameStopWatcher = new ManagementEventWatcher(string.Format(EndStartQuery, gameProcessName));

            _gameStartWatcher.EventArrived += OnGameStarted;
            _gameStopWatcher.EventArrived += OnGameEnded;

            _gameStartWatcher.Start();
            _gameStopWatcher.Start();
        }

        public static GameMonitorWmiManager Instance(string gameProcessName)
        {
            return _instance ?? (_instance = new GameMonitorWmiManager(gameProcessName));
        }

        private void OnGameStarted(object sender, EventArrivedEventArgs args)
        {
            if (Started != null)
            {
                Started.Raise(this, args);
            }
        }

        private void OnGameEnded(object sender, EventArrivedEventArgs args)
        {
            if (Ended != null)
            {
                Ended.Raise(this, args);
            }
        }


        public delegate void GameStartedEventHandler(object sender, EventArrivedEventArgs args);
        public event GameStartedEventHandler Started;

        public delegate void GameEndedEventHandler(object sender, EventArrivedEventArgs args);
        public event GameEndedEventHandler Ended;

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _gameStartWatcher.Stop();
                    _gameStopWatcher.Stop();
                    _gameStartWatcher.Dispose();
                    _gameStopWatcher.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~GameMonitorWmiManager() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
