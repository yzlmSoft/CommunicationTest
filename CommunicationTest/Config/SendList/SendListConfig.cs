using DataPairs;
using DataPairs.Interfaces;

namespace CommunicationTest.Config.SendList
{
    class SendListConfig
    {
        private IDataPair<SendListConfig> pair = new DataPair<SendListConfig>("SendListConfig", Global.DBPath);

        public Dictionary<int, SendCmd> SendList { get; set; } = new Dictionary<int, SendCmd>();

        internal async Task<SendListConfig> GetValueAsync()
        {
            var sendListConfig = await pair.TryGetValueAsync();
            return sendListConfig;
        }

        internal async Task TrySaveChangeAsync(SendListConfig sendListConfig)
        {
            await pair.TryInitOrUpdateAsync(sendListConfig);
        }
    }
}
