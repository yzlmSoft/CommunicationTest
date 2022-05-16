namespace CommunicationTest.Config.Parser
{
    class ParserConfigManager : IParserConfig
    {
        readonly ParserConfig _parserConfig = new();

        public async Task<(ParserType, Dictionary<string, string>)> GetAsync()
        {
            var parserConfig = await _parserConfig.GetValueAsync();
            return (parserConfig.parserType, parserConfig.Parsers);
        }

        public async Task SetAsync(ParserType parserType, Dictionary<string, string> dict)
        {
            var parserConfig = await _parserConfig.GetValueAsync();
            parserConfig.parserType = parserType;
            parserConfig.Parsers = dict;
            await _parserConfig.TrySaveChangeAsync(parserConfig);
        }
    }
}
