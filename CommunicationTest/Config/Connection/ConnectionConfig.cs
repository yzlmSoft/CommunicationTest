using DataPairs;
using DataPairs.Interfaces;

namespace CommunicationTest.Config.Connection
{
    class ConnectionConfig
    {
        private readonly IDataPair<ConnectionConfig> pair = new DataPair<ConnectionConfig>("ConnectionConfig", Global.DBPath);

        public Dictionary<string, string> Connection { get; set; } = new Dictionary<string, string>()
        {
            {"PortName","COM1"},
            {"BaudRate","9600"},
            {"Parity","None"},
            {"DataBits","8"},
            {"StopBits","One"},
            {"Dtr","False"},
            {"Rts","False"},
            {"TCPServerIP","Any"},
            {"TCPServerPort","2756"},
            {"TCPClientIP","127.0.0.1"},
            {"TCPClientPort","2756"}
        };

        public ConnectionType ConnectionType { get; set; } = ConnectionType.SerialPort;

        public bool AutoConnect { get; set; }

        internal async Task<ConnectionConfig> GetValueAsync()
        {
            var connectionConfig = await pair.TryGetValueAsync();
            return connectionConfig;
        }

        internal async Task TrySaveChangeAsync(ConnectionConfig connectionConfig)
        {
            await pair.TryInitOrUpdateAsync(connectionConfig);
        }
    }
}
