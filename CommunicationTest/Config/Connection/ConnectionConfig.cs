using DataPairs;
using DataPairs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTest.Config.Connection
{
    class ConnectionConfig
    {
        private static IDataPair<ConnectionConfig> pair = new DataPair<ConnectionConfig>("ConnectionConfig");

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

        internal static async Task InitDBAsync()
        {
            pair = new DataPair<ConnectionConfig>("ConnectionConfig", Global.DBPath);
            await GetValueAsync();
        }

        internal static async Task<ConnectionConfig> GetValueAsync()
        {
            var connectionConfig = await pair.TryGetValueAsync();
            return connectionConfig;
        }

        internal static async Task TrySaveChangeAsync(ConnectionConfig connectionConfig)
        {
            await pair.TryInitOrUpdateAsync(connectionConfig);
        }
    }
}
