using DataPairs;
using DataPairs.Interfaces;

namespace CommunicationTest.Config.AutoReply
{
    class AutoReplyConfig
    {
        private readonly IDataPair<AutoReplyConfig> pair = new DataPair<AutoReplyConfig>("AutoReplyConfig", Global.DBPath);

        public Dictionary<string, (byte[] value, int delay)> AutoReplys { get; set; } = new();

        public bool AutoReply { get; set; }

        internal async Task<AutoReplyConfig> GetValueAsync()
        {
            var autoReplyConfig = await pair.TryGetValueAsync();
            return autoReplyConfig;
        }

        internal async Task TrySaveChangeAsync(AutoReplyConfig autoReplyConfig)
        {
            await pair.TryInitOrUpdateAsync(autoReplyConfig);
        }
    }
}
