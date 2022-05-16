namespace CommunicationTest.Config.Connection
{
    class ConnectionConfigManager : IConnectionConfig
    {
        ConnectionConfig _connectionConfig = new();

        public async Task<bool> AutoConnectAsync()
        {
            var connectionConfig = await _connectionConfig.GetValueAsync();
            return connectionConfig.AutoConnect;
        }

        public async Task<(ConnectionType, Dictionary<string, string>)> GetAsync()
        {
            var connectionConfig = await _connectionConfig.GetValueAsync();
            return (connectionConfig.ConnectionType, connectionConfig.Connection);
        }

        public async Task SetAsync(ConnectionType connectionType, Dictionary<string, string> dict)
        {
            var connectionConfig = await _connectionConfig.GetValueAsync();
            connectionConfig.ConnectionType = connectionType;
            connectionConfig.Connection = dict;
            await _connectionConfig.TrySaveChangeAsync(connectionConfig);
        }

        public async Task SetAutoConnectAsync(bool auto)
        {
            var connectionConfig = await _connectionConfig.GetValueAsync();
            connectionConfig.AutoConnect = auto;
            await _connectionConfig.TrySaveChangeAsync(connectionConfig);
        }
    }
}
