﻿namespace CommunicationTest.Config.SendList
{
    public class SendCmd
    {
        public int Index { get; set; }
        public bool Used { get; set; }
        public string CName { get; set; }
        public SendType SendType { get; set; }
        public byte[] Cmd { get; set; }
        public bool HaveR { get; set; }
        public bool HaveN { get; set; }
    }
}