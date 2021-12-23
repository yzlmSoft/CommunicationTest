namespace CommunicationTest.Config.AutoReply
{
    interface IAutoReplyConfig
    {
        Task AddOrUpdateAsync(KeyValuePair<byte[], byte[]> keyValuePair);

        Task RemoveAsync(string key);

        Task<byte[]> GetAsync(byte[] key);

        Task<Dictionary<string, byte[]>> GetAsync();

        Task<bool> AutoReplyAsync();

        Task SetAutoReplyAsync(bool auto);
    }
}
