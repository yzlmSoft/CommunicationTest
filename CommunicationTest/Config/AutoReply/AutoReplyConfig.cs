using DataPairs;
using DataPairs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTest.Config.AutoReply
{
    class AutoReplyConfig
    {
        private static IDataPair<AutoReplyConfig> pair;

        public Dictionary<string, byte[]> AutoReplys { get; set; } = new Dictionary<string, byte[]>();

        public bool AutoReply { get; set; }

        internal static async Task InitDBAsync()
        {
            pair = new DataPair<AutoReplyConfig>("AutoReplyConfig", Global.DBPath);
            await GetValueAsync();
        }

        internal static async Task<AutoReplyConfig> GetValueAsync()
        {
            var autoReplyConfig = await pair.TryGetValueAsync();
            return autoReplyConfig;
        }

        internal static async Task TrySaveChangeAsync(AutoReplyConfig autoReplyConfig)
        {
            await pair.TryInitOrUpdateAsync(autoReplyConfig);
        }
    }
}
