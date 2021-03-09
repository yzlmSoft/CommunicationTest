using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTest.Config.SendList
{
    class SendListConfigManager : ISendListConfig
    {
        public SendListConfigManager()
        {
            SendListConfig.InitDBAsync().Wait();
        }

        public async Task AddOrUpdateAsync(SendCmd sendCmd)
        {
            var sendListConfig = await SendListConfig.GetValueAsync();

            if (sendListConfig.SendList.ContainsKey(sendCmd.Index))
            {
                sendListConfig.SendList[sendCmd.Index] = sendCmd;
            }
            else
            {
                sendListConfig.SendList.Add(sendCmd.Index, sendCmd);
            }
            await SendListConfig.TrySaveChangeAsync(sendListConfig);
        }

        public async Task<List<SendCmd>> GetAsync()
        {
            var sendListConfig = await SendListConfig.GetValueAsync();
            return sendListConfig.SendList.Values.ToList();
        }

        public async Task<List<SendCmd>> GetUsedAsync()
        {
            var sendListConfig = await SendListConfig.GetValueAsync();
            return sendListConfig.SendList.Values.ToList().FindAll(x => x.Used);
        }

        public async Task RemoveAsync(int index)
        {
            var sendListConfig = await SendListConfig.GetValueAsync();
            if (sendListConfig.SendList.ContainsKey(index))
            {
                sendListConfig.SendList.Remove(index);
            }
            await SendListConfig.TrySaveChangeAsync(sendListConfig);
        }
    }
}
