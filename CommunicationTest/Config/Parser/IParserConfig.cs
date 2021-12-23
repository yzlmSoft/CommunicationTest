namespace CommunicationTest.Config.Parser
{
    interface IParserConfig
    {
        Task SetAsync(ParserType parserType, Dictionary<string, string> dict);

        Task<(ParserType, Dictionary<string, string>)> GetAsync();
    }
}
