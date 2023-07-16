using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace HH_ProtobufTool
{
    public sealed class Config
    {
        /// <summary>
        /// ProtocPath
        /// </summary>
        public static string ProtocPath = "";

        public static string ClientOutProtoPath = "";
        public static string ClientOutProtoHandlerPath = "";
        public static string ClientOutProtoIdDefinePath = "";
        public static string ClientOutSocketProtoListenerPath = "";

        public static string ClientOutLuaPBPath = "";
        public static string ClientOutLuaProtoHandlerPath = "";
        public static string ClientOutLuaProtoDefPath = "";
        public static string ClientOutLuaProtoListenerPath = "";

        public static string ServerOutProtoPath = "";
        public static string ServerOutProtoIdDefinePath = "";

        /// <summary>
        /// 初始化
        /// </summary>
        public static void Init()
        {
            var path = AppDomain.CurrentDomain.BaseDirectory + "\\Config.xml";

            var doc = XDocument.Load(path);
            ProtocPath = doc.Root.Element("ProtocPath").Value;

            ClientOutProtoPath = doc.Root.Element("ClientOutProtoPath").Value;
            ClientOutProtoHandlerPath = doc.Root.Element("ClientOutProtoHandlerPath").Value;
            ClientOutProtoIdDefinePath = doc.Root.Element("ClientOutProtoIdDefinePath").Value;
            ClientOutSocketProtoListenerPath = doc.Root.Element("ClientOutSocketProtoListenerPath").Value;

            ClientOutLuaPBPath = doc.Root.Element("ClientOutLuaPBPath").Value;
            ClientOutLuaProtoHandlerPath = doc.Root.Element("ClientOutLuaProtoHandlerPath").Value;
            ClientOutLuaProtoDefPath = doc.Root.Element("ClientOutLuaProtoDefPath").Value;
            ClientOutLuaProtoListenerPath = doc.Root.Element("ClientOutLuaProtoListenerPath").Value;

            ServerOutProtoPath = doc.Root.Element("ServerOutProtoPath").Value;
            ServerOutProtoIdDefinePath = doc.Root.Element("ServerOutProtoIdDefinePath").Value;
        }
    }
}