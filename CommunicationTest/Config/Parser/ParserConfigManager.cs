namespace CommunicationTest.Config.Parser
{
    class ParserConfigManager : IParserConfig
    {
        public ParserConfigManager()
        {
            ParserConfig.InitDBAsync().Wait();
        }

        public async Task<(ParserType, Dictionary<string, string>)> GetAsync()
        {
            var parserConfig = await ParserConfig.GetValueAsync();
            return (parserConfig.parserType, parserConfig.Parsers);
        }

        public async Task SetAsync(ParserType parserType, Dictionary<string, string> dict)
        {
            var parserConfig = await ParserConfig.GetValueAsync();
            parserConfig.parserType = parserType;
            parserConfig.Parsers = dict;
            await ParserConfig.TrySaveChangeAsync(parserConfig);
        }
    }
}
