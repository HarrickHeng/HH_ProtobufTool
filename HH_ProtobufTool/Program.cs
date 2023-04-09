using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace HH_ProtobufTool
{
    class Program
    {
        public static Dictionary<int, ushort> m_StartProtoId;
        private static string userInfo = string.Empty;
        static void Main(string[] args)
        {

            Config.Init();

            m_StartProtoId = new Dictionary<int, ushort>();
            m_StartProtoId[-1] = 0;
            m_StartProtoId[0] = 10000;
            m_StartProtoId[1] = 11000;
            m_StartProtoId[2] = 12000;
            m_StartProtoId[3] = 13000;
            m_StartProtoId[4] = 14000;
            m_StartProtoId[5] = 15000;
            m_StartProtoId[6] = 16000;
            m_StartProtoId[7] = 17000;
            m_StartProtoId[8] = 18000;
            m_StartProtoId[9] = 19000;
            m_StartProtoId[10] = 20000;
            m_StartProtoId[11] = 21000;
            m_StartProtoId[12] = 22000;
            m_StartProtoId[13] = 23000;

            CreateProtoFiles();

            Console.WriteLine("正在生成协议文件...");
            System.Threading.Thread.Sleep(2000);
            ParseAll();
            CopyProtoToClient();
            CopyPBToClient();

            CreateCSharpProtoId();
            CreateCSharpListener();
            CreateCSharpHandler();

            CreateLuaProtoDef();
            CreateLuaListener();
            CreateLuaHandler();

            CreateServerProtoId();
            CopyProtoServer();
            Console.WriteLine("生成协议完毕!");
            Console.ReadLine();
        }

        private static List<Proto> protoLst = new List<Proto>();

        //生成协议文件
        private static void CreateProtoFiles()
        {
            //把这些文件复制到目标目录
            string[] files = Directory.GetFiles(Config.ProtocPath);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Extension == ".proto")
                {
                    Process.Start(Config.ProtocPath + "/protoc.exe", "--csharp_out=" + Config.ProtocPath + "/CSharpProto --proto_path=" + Config.ProtocPath + " " + fileInfo.Name);

                    Process.Start(Config.ProtocPath + "/protoc.exe", "--proto_path=" + Config.ProtocPath + " " + fileInfo.Name + " --descriptor_set_out=" + Config.ProtocPath + "/pb/" + fileInfo.Name.Replace(".proto", "") + ".pb");
                }
            }
        }

        #region 解析协议
        private static void ParseAll()
        {
            protoLst.Clear();
            string[] files = Directory.GetFiles(Config.ProtocPath + "/");
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Extension.Equals(".proto", StringComparison.CurrentCultureIgnoreCase))
                {
                    Parse(fileInfo.FullName);
                }
            }
        }
        private static void Parse(string file)
        {
            List<string> lineStrs = new List<string>();
            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                StreamReader sr = new StreamReader(fs, System.Text.Encoding.UTF8);
                while (sr.Peek() != -1)
                {
                    string lineStr = sr.ReadLine();
                    lineStrs.Add(lineStr);
                }
                sr.Close();
                fs.Close();
            }

            int len = lineStrs.Count;
            for (int i = 0; i < len; i++)
            {
                string str = lineStrs[i];
                if (str.IndexOf("message ") == 0)
                {
                    string title = lineStrs[i - 1];

                    Proto proto = new Proto();
                    proto.ProtoEnName = str.Replace("message ", "").Trim();
                    proto.ProtoCnName = title.Replace("//", "").Replace("[c#]", "").Replace("[lua]", "").Trim();

                    if (proto.Category == 1 || proto.Category == 3 || proto.Category == 5)
                    {
                        proto.IsCSharp = title.IndexOf("[c#]", StringComparison.CurrentCultureIgnoreCase) > -1;
                        proto.IsLua = title.IndexOf("[lua]", StringComparison.CurrentCultureIgnoreCase) > -1;
                    }
                    else
                    {
                        proto.IsCSharp = true;
                        proto.IsLua = true;
                    }

                    int protoId = proto.ProtoId;
                    protoLst.Add(proto);
                }
                else if (str.IndexOf("message ") > 0)
                {
                    Proto proto = new Proto();
                    proto.ProtoEnName = str.Replace("message ", "").Trim();
                    int protoId = proto.ProtoId;
                    protoLst.Add(proto);
                }
            }
        }
        #endregion

        #region 拷贝c#协议到客户端
        /// <summary>
        /// 拷贝c#协议到客户端
        /// </summary>
        private static void CopyProtoToClient()
        {
            //把这些文件复制到目标目录
            string[] files = Directory.GetFiles(Config.ProtocPath + "/CSharpProto");
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Name.IndexOf("NS2GS") > -1 || fileInfo.Name.IndexOf("GS2NS") > -1)
                {
                    continue;
                }
                File.Copy(fileInfo.FullName, Config.ClientOutProtoPath + "/" + fileInfo.Name, true);
            }
        }
        #endregion

        #region 拷贝PB文件到客户端
        private static void CopyPBToClient()
        {
            //把这些文件复制到目标目录
            string[] files = Directory.GetFiles(Config.ProtocPath + "/pb");
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Name.IndexOf("NS2GS") > -1 || fileInfo.Name.IndexOf("GS2NS") > -1)
                {
                    continue;
                }
                File.Copy(fileInfo.FullName, Config.ClientOutLuaPBPath + "/" + fileInfo.Name.Replace(".pb", ".bytes"), true);
            }
        }
        #endregion

        #region CreateCSharpProtoId 创建c#协议编号
        /// <summary>
        /// 创建c#协议编号
        /// </summary>
        private static void CreateCSharpProtoId()
        {
            StringBuilder sbr = new StringBuilder();
            sbr.AppendFormat("/// Create By HHFramework {0}\r\n", userInfo.Trim());
            sbr.Append("/// <summary>\r\n");
            sbr.Append("/// 协议编号\r\n");
            sbr.Append("/// </summary>\r\n");
            sbr.Append("public class ProtoIdDefine\r\n");
            sbr.Append("{\r\n");

            int len = protoLst.Count;
            for (int i = 0; i < len; i++)
            {
                Proto proto = protoLst[i];

                sbr.Append("    /// <summary>\r\n");
                sbr.AppendFormat("    /// {0}\r\n", proto.ProtoCnName);
                sbr.Append("    /// </summary>\r\n");
                sbr.AppendFormat("    public const ushort Proto_{0} = {1};\r\n", proto.ProtoEnName, proto.ProtoId);
                if (i < len - 1)
                {
                    sbr.Append("\r\n");
                }
            }

            sbr.Append("}");

            //写入文件
            using (FileStream fs = new FileStream(Config.ClientOutProtoIdDefinePath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(sbr.ToString());
                }
            }
        }
        #endregion

        #region CreateCSharpListener 创建c#监听
        /// <summary>
        /// 创建c#监听
        /// </summary>
        private static void CreateCSharpListener()
        {
            StringBuilder sbr = new StringBuilder();
            sbr.AppendFormat("/// Create By HHFramework {0}\r\n", userInfo.Trim());
            sbr.Append("using HHFramework;\r\n");
            sbr.Append("\r\n");
            sbr.Append("/// <summary>\r\n");
            sbr.Append("/// Socket协议监听\r\n");
            sbr.Append("/// </summary>\r\n");
            sbr.Append("public sealed class SocketProtoListener\r\n");
            sbr.Append("{\r\n");
            sbr.Append("    /// <summary>\r\n");
            sbr.Append("    /// 添加协议监听\r\n");
            sbr.Append("    /// </summary>\r\n");
            sbr.Append("    public static void AddProtoListener()\r\n");
            sbr.Append("    {\r\n");
            int len = protoLst.Count;
            for (int i = 0; i < len; i++)
            {
                Proto proto = protoLst[i];
                if (proto.IsCSharp && (proto.Category == 1 || proto.Category == 3 || proto.Category == 5))
                {
                    sbr.AppendFormat("        GameEntry.Event.SocketEvent.AddEventListener(ProtoIdDefine.Proto_{0}, {0}Handler.OnHandler);\r\n", proto.ProtoEnName);
                }
            }
            sbr.Append("    }\r\n");
            sbr.Append("\r\n");
            sbr.Append("    /// <summary>\r\n");
            sbr.Append("    /// 移除协议监听\r\n");
            sbr.Append("    /// </summary>\r\n");
            sbr.Append("    public static void RemoveProtoListener()\r\n");
            sbr.Append("    {\r\n");
            len = protoLst.Count;
            for (int i = 0; i < len; i++)
            {
                Proto proto = protoLst[i];
                if (proto.IsCSharp && (proto.Category == 1 || proto.Category == 3 || proto.Category == 5))
                {
                    sbr.AppendFormat("        GameEntry.Event.SocketEvent.RemoveEventListener(ProtoIdDefine.Proto_{0}, {0}Handler.OnHandler);\r\n", proto.ProtoEnName);
                }
            }
            sbr.Append("    }\r\n");
            sbr.Append("}");

            //写入文件
            using (FileStream fs = new FileStream(Config.ClientOutSocketProtoListenerPath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(sbr.ToString());
                }
            }
        }
        #endregion

        #region CreateCSharpHandler
        /// <summary>
        /// 创建CSharpHandler
        /// </summary>
        private static void CreateCSharpHandler()
        {
            int len = protoLst.Count;
            for (int i = 0; i < len; i++)
            {
                Proto proto = protoLst[i];
                if (proto.IsCSharp && (proto.Category == 1 || proto.Category == 3 || proto.Category == 5))
                {
                    StringBuilder sbr = new StringBuilder();
                    sbr.AppendFormat("/// Create By HHFramework {0}\r\n", userInfo.Trim());
                    sbr.Append("using HHFramework;\r\n");
                    sbr.Append("using HHFramework.Proto;\r\n");
                    sbr.Append("\r\n");
                    sbr.Append("/// <summary>\r\n");
                    sbr.AppendFormat("/// {0}\r\n", proto.ProtoCnName);
                    sbr.Append("/// </summary>\r\n");
                    sbr.AppendFormat("public class {0}Handler\r\n", proto.ProtoEnName);
                    sbr.Append("{\r\n");
                    sbr.Append("    public static void OnHandler(byte[] buffer)\r\n");
                    sbr.Append("    {\r\n");
                    sbr.AppendFormat("        {0} proto = {0}.Parser.ParseFrom(buffer);\r\n", proto.ProtoEnName);
                    sbr.Append("\r\n");
                    sbr.Append("#if DEBUG_LOG_PROTO && DEBUG_MODEL\r\n");
                    sbr.Append("        GameEntry.Log(LogCategory.Proto, \"<color=#00eaff>接收消息:</color><color=#00ff9c>\" + proto.ProtoEnName + \" \" + proto.ProtoId + \"</color>\");\r\n");
                    sbr.Append("        GameEntry.Log(LogCategory.Proto, \"<color=#c5e1dc>==>>\" + proto.ToString() + \"</color>\");\r\n");
                    sbr.Append("#endif\r\n");
                    sbr.Append("    }\r\n");
                    sbr.Append("}");


                    string path = Config.ClientOutProtoHandlerPath + string.Format("/{0}Handler.cs", proto.ProtoEnName);

                    if (!File.Exists(path))
                    {
                        //写入文件
                        using (FileStream fs = new FileStream(path, FileMode.Create))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.Write(sbr.ToString());
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region CreateLuaProtoDef
        /// <summary>
        /// 创建Lua协议定义
        /// </summary>
        private static void CreateLuaProtoDef()
        {
            StringBuilder sbr = new StringBuilder();
            sbr.AppendFormat("-- Create By HHFramework {0}\r\n", userInfo.Trim());
            sbr.Append("local ProtoBase = Class(\"ProtoBase\")\r\n");
            sbr.Append("\r\n");
            sbr.Append("function ProtoBase:__init(packet)\r\n");
            sbr.Append("    self.Packet = packet\r\n");
            sbr.Append("end\r\n");
            sbr.Append("\r\n");
            sbr.Append("function ProtoBase:GetID()\r\n");
            sbr.Append("    assert(false, \"function ProtoBase:GetID() must override!!!\")\r\n");
            sbr.Append("end\r\n");
            sbr.Append("\r\n");
            sbr.Append("function ProtoBase:GetCategory()\r\n");
            sbr.Append("    assert(false, \"function ProtoBase:GetCategory() must override!!!\")\r\n");
            sbr.Append("end\r\n");
            sbr.Append("\r\n");
            sbr.Append("ProtoIDName = {\r\n");
            int len = protoLst.Count;
            for (int i = 0; i < len; i++)
            {
                Proto proto = protoLst[i];
                if (proto.IsLua && (proto.Category == 0 || proto.Category == 2 || proto.Category == 4))
                {
                    sbr.AppendFormat("    [{0}] = \"HHFramework.Proto.{1}\",\r\n", proto.ProtoId, proto.ProtoEnName);
                }
            }
            sbr.Append("}\r\n");

            sbr.Append("\r\n");
            for (int i = 0; i < len; i++)
            {
                Proto proto = protoLst[i];
                if (proto.IsLua && (proto.Category == 0 || proto.Category == 2 || proto.Category == 4))
                {
                    sbr.AppendFormat("proto_{0} = Class(\"proto_{0}\", ProtoBase)\r\n", proto.ProtoEnName);
                    sbr.AppendFormat("function proto_{0}:GetID()\r\n", proto.ProtoEnName);
                    sbr.AppendFormat("    return {0};\r\n", proto.ProtoId);
                    sbr.Append("end\r\n");
                    sbr.AppendFormat("function proto_{0}:GetCategory()\r\n", proto.ProtoEnName);
                    sbr.AppendFormat("    return ProtoCategory.{0};\r\n", proto.CategoryName);
                    sbr.Append("end");
                    sbr.Append("\r\n\r\n");
                }
            }
            //写入文件
            using (FileStream fs = new FileStream(Config.ClientOutLuaProtoDefPath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(sbr.ToString().Trim());
                }
            }
        }
        #endregion

        #region CreateLuaListener 创建Lua监听
        /// <summary>
        /// 创建Lua监听
        /// </summary>
        private static void CreateLuaListener()
        {
            StringBuilder sbr = new StringBuilder();
            sbr.AppendFormat("-- Create By HHFramework {0}\r\n", userInfo.Trim());
            sbr.Append("\r\n");
            int len = protoLst.Count;
            for (int i = 0; i < len; i++)
            {
                Proto proto = protoLst[i];
                if (proto.IsLua && (proto.Category == 1 || proto.Category == 3 || proto.Category == 5))
                {
                    sbr.AppendFormat("require(\"DataNode/ProtoHandler/{0}Handler\");\r\n", proto.ProtoEnName);
                }
            }
            sbr.Append("\r\n");
            sbr.Append("SocketProtoListenerForLua = { };\r\n");
            sbr.Append("\r\n");
            sbr.Append("local this = SocketProtoListenerForLua;\r\n");
            sbr.Append("\r\n");
            sbr.Append("function SocketProtoListenerForLua.AddProtoListener()\r\n");
            for (int i = 0; i < len; i++)
            {
                Proto proto = protoLst[i];
                if (proto.IsLua && (proto.Category == 1 || proto.Category == 3 || proto.Category == 5))
                {
                    sbr.AppendFormat("    GameEntry.Event.SocketEvent:AddEventListener({0}, {1}Handler.OnHandle);\r\n", proto.ProtoId, proto.ProtoEnName);
                }
            }
            sbr.Append("end\r\n");
            sbr.Append("\r\n");
            sbr.Append("function SocketProtoListenerForLua.RemoveProtoListener()\r\n");
            for (int i = 0; i < len; i++)
            {
                Proto proto = protoLst[i];
                if (proto.IsLua && (proto.Category == 1 || proto.Category == 3 || proto.Category == 5))
                {
                    sbr.AppendFormat("    GameEntry.Event.SocketEvent:RemoveEventListener({0}, {1}Handler.OnHandle);\r\n", proto.ProtoId, proto.ProtoEnName);
                }
            }
            sbr.Append("end");
            //写入文件
            using (FileStream fs = new FileStream(Config.ClientOutLuaProtoListenerPath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(sbr.ToString().Trim());
                }
            }
        }
        #endregion

        #region CreateLuaHandler 创建LuaHandler
        /// <summary>
        /// 创建LuaHandler
        /// </summary>
        private static void CreateLuaHandler()
        {
            int len = protoLst.Count;
            for (int i = 0; i < len; i++)
            {
                Proto proto = protoLst[i];
                if (proto.IsLua && (proto.Category == 1 || proto.Category == 3 || proto.Category == 5))
                {
                    StringBuilder sbr = new StringBuilder();
                    sbr.AppendFormat("-- Create By HHFramework {0}\r\n", userInfo.Trim());

                    sbr.Append("\r\n");
                    sbr.AppendFormat("--{0}\r\n", proto.ProtoCnName);
                    sbr.AppendFormat("{0}Handler = {{ }}\r\n", proto.ProtoEnName);
                    sbr.AppendFormat("local this = {0}Handler\r\n", proto.ProtoEnName);
                    sbr.Append("\r\n");
                    sbr.AppendFormat("function {0}Handler.OnHandle(buffer)\r\n", proto.ProtoEnName);
                    sbr.AppendFormat("    local proto = assert(GlobalPB.decode(\"HHFramework.Proto.{0}\", buffer));\r\n", proto.ProtoEnName);
                    sbr.Append("\r\n");
                    sbr.Append("    if(GameInit.GetDebugLogProto()) then\r\n");
                    sbr.AppendFormat("        print(string.format(\"<color=#00eaff>接收消息:</color><color=#00ff9c>%s %s</color>\", \"HHFramework.Proto.{0}\", {1}));\r\n", proto.ProtoEnName, proto.ProtoId);
                    sbr.Append("        print(string.format(\"<color=#c5e1dc>==>>%s</color>\", json.encode(proto)));\r\n");
                    sbr.Append("    end\r\n");
                    sbr.Append("end\r\n");

                    string path = Config.ClientOutLuaProtoHandlerPath + string.Format("/{0}Handler.bytes", proto.ProtoEnName);

                    if (!File.Exists(path))
                    {
                        //写入文件
                        using (FileStream fs = new FileStream(path, FileMode.Create))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                            {
                                sw.Write(sbr.ToString());
                            }
                        }
                    }
                }
            }
        }
        #endregion


        #region CreateServerProtoId 创建c#服务器协议编号
        /// <summary>
        /// 创建c#服务器协议编号
        /// </summary>
        private static void CreateServerProtoId()
        {
            StringBuilder sbr = new StringBuilder();
            sbr.AppendFormat("/// <summary>\r\n");
            sbr.AppendFormat("/// Create By HHFramework {0}\r\n", userInfo.Trim());
            sbr.AppendFormat("/// </summary>\r\n");
            sbr.Append("/// <summary>\r\n");
            sbr.Append("/// 协议编号\r\n");
            sbr.Append("/// </summary>\r\n");
            sbr.Append("public class ProtoIdDefine\r\n");
            sbr.Append("{\r\n");

            int len = protoLst.Count;
            for (int i = 0; i < len; i++)
            {
                Proto proto = protoLst[i];

                sbr.Append("    /// <summary>\r\n");
                sbr.AppendFormat("    /// {0}\r\n", proto.ProtoCnName);
                sbr.Append("    /// </summary>\r\n");
                sbr.AppendFormat("    public const ushort Proto_{0} = {1};\r\n", proto.ProtoEnName, proto.ProtoId);
                if (i < len - 1)
                {
                    sbr.Append("\r\n");
                }
            }

            sbr.Append("}");

            //写入文件
            using (FileStream fs = new FileStream(Config.ServerOutProtoIdDefinePath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(sbr.ToString());
                }
            }
        }
        #endregion

        #region 拷贝c#协议到服务器
        /// <summary>
        /// 拷贝c#协议到服务器
        /// </summary>
        private static void CopyProtoServer()
        {
            //把这些文件复制到目标目录
            string[] files = Directory.GetFiles(Config.ProtocPath + "/CSharpProto");
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                File.Copy(fileInfo.FullName, Config.ServerOutProtoPath + "/" + fileInfo.Name, true);
            }
        }
        #endregion
    }

    #region Proto
    public class Proto
    {
        private ushort? m_ProtoId;
        public ushort ProtoId
        {
            get
            {
                if (m_ProtoId == null)
                {
                    m_ProtoId = ++Program.m_StartProtoId[Category];
                }
                return m_ProtoId.Value;
            }
        }
        public string ProtoEnName;
        public string ProtoCnName;
        public bool IsCSharp;
        public bool IsLua;
        public int Category
        {
            get
            {
                if (ProtoEnName.IndexOf("C2GWS_") == 0)
                {
                    return 0;
                }
                else if (ProtoEnName.IndexOf("GWS2C_") == 0)
                {
                    return 1;
                }
                else if (ProtoEnName.IndexOf("C2WS_") == 0)
                {
                    return 2;
                }
                else if (ProtoEnName.IndexOf("WS2C_") == 0)
                {
                    return 3;
                }
                else if (ProtoEnName.IndexOf("C2GS_") == 0)
                {
                    return 4;
                }
                else if (ProtoEnName.IndexOf("GS2C_") == 0)
                {
                    return 5;
                }
                else if (ProtoEnName.IndexOf("GS2WS_") == 0)
                {
                    return 6;
                }
                else if (ProtoEnName.IndexOf("WS2GS_") == 0)
                {
                    return 7;
                }
                else if (ProtoEnName.IndexOf("GWS2WS_") == 0)
                {
                    return 8;
                }
                else if (ProtoEnName.IndexOf("WS2GWS_") == 0)
                {
                    return 9;
                }
                else if (ProtoEnName.IndexOf("GWS2GS_") == 0)
                {
                    return 10;
                }
                else if (ProtoEnName.IndexOf("GS2GWS_") == 0)
                {
                    return 11;
                }
                else if (ProtoEnName.IndexOf("GS2NS_") == 0)
                {
                    return 10;
                }
                else if (ProtoEnName.IndexOf("NS2GS_") == 0)
                {
                    return 11;
                }
                return -1;
            }
        }

        public string CategoryName
        {
            get
            {
                switch (Category)
                {
                    case 0:
                        return "Client2GatewayServer";
                    case 1:
                        return "GatewayServer2Client";
                    case 2:
                        return "Client2WorldServer";
                    case 3:
                        return "WorldServer2Client";
                    case 4:
                        return "Client2GameServer";
                    case 5:
                        return "GameServer2Client";
                    case 6:
                        return "GameServer2WorldServer";
                    case 7:
                        return "WorldServer2GameServer";
                    case 8:
                        return "GatewayServer2WorldServer";
                    case 9:
                        return "WorldServer2GatewayServer";
                    case 10:
                        return "GatewayServer2GameServer";
                    case 11:
                        return "GameServer2GatewayServer";
                }
                return "None";
            }
        }
    }
    #endregion
}