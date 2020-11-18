using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTest.Config.Connection
{
    interface IConnectionConfig
    {
        Task SetAsync(ConnectionType connectionType, Dictionary<string, string> dict);

        Task<(ConnectionType, Dictionary<string, string>)> GetAsync();

        Task<bool> AutoConnectAsync();

        Task SetAutoConnectAsync(bool auto);
    }
}
