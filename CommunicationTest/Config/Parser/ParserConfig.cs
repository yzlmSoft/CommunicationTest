using DataPairs;
using DataPairs.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationTest.Config.Parser
{
    class ParserConfig
    {
        private static IDataPair<ParserConfig> pair = new DataPair<ParserConfig>("ParserConfig");

        public Dictionary<string, string> Parsers { get; set; } = new Dictionary<string, string>()
        {
            {"Time","20"},
            {"HLHead",""},
            {"HLType","头后FloatL"},
            {"HLLength",""},
            {"HFHead",""},
            {"HFFoot",""},
            {"FFoot",""}
        };

        public ParserType parserType { get; set; } = ParserType.TimeParser;

        internal static async Task InitDBAsync()
        {
            pair = new DataPair<ParserConfig>("ParserConfig", Global.DBPath);
            await GetValueAsync();
        }

        internal static async Task<ParserConfig> GetValueAsync()
        {
            var parserConfig = await pair.TryGetValueAsync();
            return parserConfig;
        }

        internal static async Task TrySaveChangeAsync(ParserConfig parserConfig)
        {
            await pair.TryInitOrUpdateAsync(parserConfig);
        }
    }
}
