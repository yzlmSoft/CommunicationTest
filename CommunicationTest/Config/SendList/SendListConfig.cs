using DataPairs;
using DataPairs.Interfaces;

namespace CommunicationTest.Config.SendList
{
    class SendListConfig
    {
        private static IDataPair<SendListConfig> pair;

        public Dictionary<int, SendCmd> SendList { get; set; } = new Dictionary<int, SendCmd>();

        internal static async Task InitDBAsync()
        {
            pair = new DataPair<SendListConfig>("SendListConfig", Global.DBPath);
            await GetValueAsync();
        }

        internal static async Task<SendListConfig> GetValueAsync()
        {
            var sendListConfig = await pair.TryGetValueAsync();
            return sendListConfig;
        }

        internal static async Task TrySaveChangeAsync(SendListConfig sendListConfig)
        {
            await pair.TryInitOrUpdateAsync(sendListConfig);
        }
    }
}
