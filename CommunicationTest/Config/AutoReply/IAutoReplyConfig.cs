namespace CommunicationTest.Config.AutoReply
{
    interface IAutoReplyConfig
    {
        Task AddOrUpdateAsync(byte[] key, byte[] value, int delayTime = 0);

        Task RemoveAsync(string key);

        Task<(byte[] value, int delayTime)> GetAsync(byte[] key);

        Task<Dictionary<string, (byte[] value, int delayTime)>> GetAsync();

        Task<bool> AutoReplyAsync();

        Task SetAutoReplyAsync(bool auto);
    }
}
