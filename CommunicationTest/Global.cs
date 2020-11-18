using Communication.Bus;
using Parser.Interfaces;
using CommunicationTest.Config.AutoReply;
using CommunicationTest.Config.Connection;
using CommunicationTest.Config.Parser;
using CommunicationTest.Config.SendList;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopPortLib;

namespace CommunicationTest
{
    static class Global
    {
        public static IAutoReplyConfig AutoReplyConfig { get; set; }

        public static IConnectionConfig ConnectionConfig { get; set; }

        public static IParserConfig ParserConfig { get; set; }

        public static ISendListConfig SendListConfig { get; set; }

        public static TopPort TopPort { get; set; }

        public static TcpServer TcpServer { get; set; }

        public static IParser Parser { get; set; }

        public static ConcurrentDictionary<int, IParser> Parsers { get; set; } = new ConcurrentDictionary<int, IParser>();
    }
}
