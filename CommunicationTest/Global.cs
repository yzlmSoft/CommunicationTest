﻿using CommunicationTest.Config.AutoReply;
using CommunicationTest.Config.Connection;
using CommunicationTest.Config.Parser;
using CommunicationTest.Config.SendList;
using CommunicationTest.UC;
using Parser.Interfaces;
using System.Collections.Concurrent;
using TopPortLib.Interfaces;

namespace CommunicationTest
{
    static class Global
    {
        public static IAutoReplyConfig? AutoReplyConfig { get; set; }

        public static IConnectionConfig? ConnectionConfig { get; set; }

        public static IParserConfig? ParserConfig { get; set; }

        public static ISendListConfig? SendListConfig { get; set; }

        public static ITopPort? TopPort { get; set; }

        public static ITopPort_Server? TcpServer { get; set; }

        public static IParser? Parser { get; set; }

        public static ConcurrentDictionary<Guid, DataReceive> DataReceives { get; set; } = new();

        public static readonly string DPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PairsDB.dll");
        public static string DBPath { get; set; } = DPath;
    }
}
