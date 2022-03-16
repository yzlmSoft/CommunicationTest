using Utils;

namespace CommunicationTest.Config.AutoReply
{
    class AutoReplyConfigManager : IAutoReplyConfig
    {
        public AutoReplyConfigManager()
        {
            AutoReplyConfig.InitDBAsync().Wait();
        }

        public async Task AddOrUpdateAsync(byte[] key, byte[] value, int delayTime = 0)
        {
            var autoReplyConfig = await AutoReplyConfig.GetValueAsync();
            var skey = StringByteUtils.BytesToString(key);
            if (autoReplyConfig.AutoReplys.ContainsKey(skey))
            {
                autoReplyConfig.AutoReplys[skey] = (value, delayTime);
            }
            else
            {
                autoReplyConfig.AutoReplys.Add(skey, (value, delayTime));
            }
            await AutoReplyConfig.TrySaveChangeAsync(autoReplyConfig);
        }

        public async Task<bool> AutoReplyAsync()
        {
            var autoReplyConfig = await AutoReplyConfig.GetValueAsync();
            return autoReplyConfig.AutoReply;
        }

        public async Task<(byte[] value, int delayTime)> GetAsync(byte[] key)
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

        public async Task<Dictionary<string, (byte[] value, int delayTime)>> GetAsync()
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
