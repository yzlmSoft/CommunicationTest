namespace CommunicationTest.Config.SendList
{
    interface ISendListConfig
    {
        Task<List<SendCmd>> GetAsync();

        Task<List<SendCmd>> GetUsedAsync();

        Task AddOrUpdateAsync(SendCmd sendCmd);

        Task RemoveAsync(int index);
    }
}
