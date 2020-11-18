using DataPairs;
using DataPairs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTest.Config.SendList
{
    class SendListConfig
    {
        private static readonly IDataPair<SendListConfig> pair = new DataPair<SendListConfig>("SendListConfig");

        public Dictionary<int, SendCmd> SendList { get; set; } = new Dictionary<int, SendCmd>();

        public static async Task<SendListConfig> GetValueAsync()
        {
            var sendListConfig = await pair.TryGetValueAsync();
            return sendListConfig;
        }

        public static async Task TrySaveChangeAsync(SendListConfig sendListConfig)
        {
            await pair.TryInitOrUpdateAsync(sendListConfig);
        }
    }
}
