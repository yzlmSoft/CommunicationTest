using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTest.Config.Connection
{
    class ConnectionConfigManager : IConnectionConfig
    {
        public ConnectionConfigManager()
        {
            ConnectionConfig.InitDBAsync().Wait();
        }

        public async Task<bool> AutoConnectAsync()
        {
            var connectionConfig = await ConnectionConfig.GetValueAsync();
            return connectionConfig.AutoConnect;
        }

        public async Task<(ConnectionType, Dictionary<string, string>)> GetAsync()
        {
            var connectionConfig = await ConnectionConfig.GetValueAsync();
            return (connectionConfig.ConnectionType, connectionConfig.Connection);
        }

        public async Task SetAsync(ConnectionType connectionType, Dictionary<string, string> dict)
        {
            var connectionConfig = await ConnectionConfig.GetValueAsync();
            connectionConfig.ConnectionType = connectionType;
            connectionConfig.Connection = dict;
            await ConnectionConfig.TrySaveChangeAsync(connectionConfig);
        }

        public async Task SetAutoConnectAsync(bool auto)
        {
            var connectionConfig = await ConnectionConfig.GetValueAsync();
            connectionConfig.AutoConnect = auto;
            await ConnectionConfig.TrySaveChangeAsync(connectionConfig);
        }
    }
}
