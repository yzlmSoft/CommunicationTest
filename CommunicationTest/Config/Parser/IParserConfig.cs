using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTest.Config.Parser
{
    interface IParserConfig
    {
        Task SetAsync(ParserType parserType, Dictionary<string, string> dict);

        Task<(ParserType, Dictionary<string, string>)> GetAsync();
    }
}
