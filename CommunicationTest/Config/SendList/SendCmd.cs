namespace CommunicationTest.Config.SendList
{
    public class SendCmd
    {
        public int ID { get; set; }
        public bool Used { get; set; }
        public string? CName { get; set; }
        public SendType SendType { get; set; }
        public byte[] Cmd { get; set; } = null!;
        public bool HaveR { get; set; }
        public bool HaveN { get; set; }
        public CrcType CrcType { get; set; }
    }
}