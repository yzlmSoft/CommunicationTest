using DataPairs;
using DataPairs.Interfaces;

namespace CommunicationTest.Config.Parser
{
    class ParserConfig
    {
        private readonly IDataPair<ParserConfig> pair = new DataPair<ParserConfig>("ParserConfig", Global.DBPath);

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

        internal async Task<ParserConfig> GetValueAsync()
        {
            var parserConfig = await pair.TryGetValueAsync();
            return parserConfig;
        }

        internal async Task TrySaveChangeAsync(ParserConfig parserConfig)
        {
            await pair.TryInitOrUpdateAsync(parserConfig);
        }
    }
}
