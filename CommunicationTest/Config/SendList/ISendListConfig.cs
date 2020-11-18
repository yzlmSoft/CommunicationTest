using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
