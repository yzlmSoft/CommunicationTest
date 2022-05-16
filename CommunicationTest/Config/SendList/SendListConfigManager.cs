namespace CommunicationTest.Config.SendList
{
    class SendListConfigManager : ISendListConfig
    {
        readonly SendListConfig _sendListConfig = new();

        public async Task AddOrUpdateAsync(SendCmd sendCmd)
        {
            var sendListConfig = await _sendListConfig.GetValueAsync();

            if (sendListConfig.SendList.ContainsKey(sendCmd.ID))
            {
                sendListConfig.SendList[sendCmd.ID] = sendCmd;
            }
            else
            {
                sendListConfig.SendList.Add(sendCmd.ID, sendCmd);
            }
            await _sendListConfig.TrySaveChangeAsync(sendListConfig);
        }

        public async Task<List<SendCmd>> GetAsync()
        {
            var sendListConfig = await _sendListConfig.GetValueAsync();
            return sendListConfig.SendList.Values.ToList();
        }

        public async Task<List<SendCmd>> GetUsedAsync()
        {
            var sendListConfig = await _sendListConfig.GetValueAsync();
            return sendListConfig.SendList.Values.ToList().FindAll(x => x.Used);
        }

        public async Task RemoveAsync(int index)
        {
            var sendListConfig = await _sendListConfig.GetValueAsync();
            if (sendListConfig.SendList.ContainsKey(index))
            {
                sendListConfig.SendList.Remove(index);
            }
            await _sendListConfig.TrySaveChangeAsync(sendListConfig);
        }
    }
}
