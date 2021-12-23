namespace CommunicationTest.Config.Connection
{
    interface IConnectionConfig
    {
        Task SetAsync(ConnectionType connectionType, Dictionary<string, string> dict);

        Task<(ConnectionType, Dictionary<string, string>)> GetAsync();

        Task<bool> AutoConnectAsync();

        Task SetAutoConnectAsync(bool auto);
    }
}
