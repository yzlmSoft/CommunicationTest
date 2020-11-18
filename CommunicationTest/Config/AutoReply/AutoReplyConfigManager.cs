using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace CommunicationTest.Config.AutoReply
{
    class AutoReplyConfigManager : IAutoReplyConfig
    {
        public async Task AddOrUpdateAsync(KeyValuePair<byte[], byte[]> keyValuePair)
        {
            var autoReplyConfig = await AutoReplyConfig.GetValueAsync();
            var key = StringByteUtils.BytesToString(keyValuePair.Key);
            if (autoReplyConfig.AutoReplys.ContainsKey(key))
            {
                autoReplyConfig.AutoReplys[key] = keyValuePair.Value;
            }
            else
            {
                autoReplyConfig.AutoReplys.Add(key, keyValuePair.Value);
            }
            await AutoReplyConfig.TrySaveChangeAsync(autoReplyConfig);
        }

        public async Task<bool> AutoReplyAsync()
        {
            var autoReplyConfig = await AutoReplyConfig.GetValueAsync();
            return autoReplyConfig.AutoReply;
        }

        public async Task<byte[]> GetAsync(byte[] key)
        {
            var skey = StringByteUtils.BytesToString(key);
            var autoReplyConfig = await AutoReplyConfig.GetValueAsync();
            if (autoReplyConfig.AutoReplys.ContainsKey(skey))
            {
                return autoReplyConfig.AutoReplys[skey];
            }
            else
            {
                return default;
            }
        }

        public async Task<Dictionary<string, byte[]>> GetAsync()
        {
            var autoReplyConfig = await AutoReplyConfig.GetValueAsync();
            return autoReplyConfig.AutoReplys;
        }

        public async Task RemoveAsync(string key)
        {
            var autoReplyConfig = await AutoReplyConfig.GetValueAsync();
            if (autoReplyConfig.AutoReplys.ContainsKey(key))
            {
                autoReplyConfig.AutoReplys.Remove(key);
            }
            await AutoReplyConfig.TrySaveChangeAsync(autoReplyConfig);
        }

        public async Task SetAutoReplyAsync(bool auto)
        {
            var autoReplyConfig = await AutoReplyConfig.GetValueAsync();
            autoReplyConfig.AutoReply = auto;
            await AutoReplyConfig.TrySaveChangeAsync(autoReplyConfig);
        }
    }
}
