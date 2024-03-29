// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto_GWS2C.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HHFramework.Proto {

  /// <summary>Holder for reflection information generated from Proto_GWS2C.proto</summary>
  public static partial class ProtoGWS2CReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto_GWS2C.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoGWS2CReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQcm90b19HV1MyQy5wcm90bxIRSEhGcmFtZXdvcmsuUHJvdG8aElByb3Rv",
            "X0NvbW1vbi5wcm90byInChVHV1MyQ19SZXR1cm5SZWdDbGllbnQSDgoGUmVz",
            "dWx0GAEgASgIIk0KD0dXUzJDX0hlYXJ0YmVhdBIMCgRUaW1lGAEgASgDEhIK",
            "ClNlcnZlclRpbWUYAiABKAMSGAoQVG9HYW1lU2VydmVyUGluZxgDIAEoBSJD",
            "ChNHV1MyQ19SZXR1cm5PZmZsaW5lEiwKBFR5cGUYASABKA4yHi5ISEZyYW1l",
            "d29yay5Qcm90by5PZmZsaW5lVHlwZSLnAQocR1dTMkNfUmV0dXJuR2FtZVNl",
            "cnZlckNvbmZpZxJvChRHYW1lU2VydmVyQ29uZmlnTGlzdBgBIAMoCzJRLkhI",
            "RnJhbWV3b3JrLlByb3RvLkdXUzJDX1JldHVybkdhbWVTZXJ2ZXJDb25maWcu",
            "R1dTMkNfUmV0dXJuR2FtZVNlcnZlckNvbmZpZ19JdGVtGlYKIUdXUzJDX1Jl",
            "dHVybkdhbWVTZXJ2ZXJDb25maWdfSXRlbRISCgpDb25maWdDb2RlGAEgASgJ",
            "Eg4KBklzT3BlbhgCIAEoCBINCgVQYXJhbRgDIAEoCWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HHFramework.Proto.ProtoCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GWS2C_ReturnRegClient), global::HHFramework.Proto.GWS2C_ReturnRegClient.Parser, new[]{ "Result" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GWS2C_Heartbeat), global::HHFramework.Proto.GWS2C_Heartbeat.Parser, new[]{ "Time", "ServerTime", "ToGameServerPing" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GWS2C_ReturnOffline), global::HHFramework.Proto.GWS2C_ReturnOffline.Parser, new[]{ "Type" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GWS2C_ReturnGameServerConfig), global::HHFramework.Proto.GWS2C_ReturnGameServerConfig.Parser, new[]{ "GameServerConfigList" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.GWS2C_ReturnGameServerConfig.Types.GWS2C_ReturnGameServerConfig_Item), global::HHFramework.Proto.GWS2C_ReturnGameServerConfig.Types.GWS2C_ReturnGameServerConfig_Item.Parser, new[]{ "ConfigCode", "IsOpen", "Param" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///网关服务器返回注册客户端结果[c#]
  /// </summary>
  public sealed partial class GWS2C_ReturnRegClient : HHFramework.IProto, pb::IMessage<GWS2C_ReturnRegClient> {
    private static readonly pb::MessageParser<GWS2C_ReturnRegClient> _parser = new pb::MessageParser<GWS2C_ReturnRegClient>(() => new GWS2C_ReturnRegClient());
    public ushort ProtoId => ProtoIdDefine.Proto_GWS2C_ReturnRegClient;
    public string ProtoEnName => "GWS2C_ReturnRegClient";
    public ProtoCategory Category => ProtoCategory.GatewayServer2Client;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GWS2C_ReturnRegClient> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGWS2CReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_ReturnRegClient() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_ReturnRegClient(GWS2C_ReturnRegClient other) : this() {
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_ReturnRegClient Clone() {
      return new GWS2C_ReturnRegClient(this);
    }

    /// <summary>Field number for the "Result" field.</summary>
    public const int ResultFieldNumber = 1;
    private bool result_;
    /// <summary>
    ///结果
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GWS2C_ReturnRegClient);
    }

    public bool Equals(GWS2C_ReturnRegClient other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != false) hash ^= Result.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != false) {
        output.WriteRawTag(8);
        output.WriteBool(Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(GWS2C_ReturnRegClient other) {
      if (other == null) {
        return;
      }
      if (other.Result != false) {
        Result = other.Result;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Result = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///网关服务器返回心跳消息[c#]
  /// </summary>
  public sealed partial class GWS2C_Heartbeat : HHFramework.IProto, pb::IMessage<GWS2C_Heartbeat> {
    private static readonly pb::MessageParser<GWS2C_Heartbeat> _parser = new pb::MessageParser<GWS2C_Heartbeat>(() => new GWS2C_Heartbeat());
    public ushort ProtoId => ProtoIdDefine.Proto_GWS2C_Heartbeat;
    public string ProtoEnName => "GWS2C_Heartbeat";
    public ProtoCategory Category => ProtoCategory.GatewayServer2Client;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GWS2C_Heartbeat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGWS2CReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_Heartbeat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_Heartbeat(GWS2C_Heartbeat other) : this() {
      time_ = other.time_;
      serverTime_ = other.serverTime_;
      toGameServerPing_ = other.toGameServerPing_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_Heartbeat Clone() {
      return new GWS2C_Heartbeat(this);
    }

    /// <summary>Field number for the "Time" field.</summary>
    public const int TimeFieldNumber = 1;
    private long time_;
    /// <summary>
    ///时间
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    /// <summary>Field number for the "ServerTime" field.</summary>
    public const int ServerTimeFieldNumber = 2;
    private long serverTime_;
    /// <summary>
    ///服务器时间
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ServerTime {
      get { return serverTime_; }
      set {
        serverTime_ = value;
      }
    }

    /// <summary>Field number for the "ToGameServerPing" field.</summary>
    public const int ToGameServerPingFieldNumber = 3;
    private int toGameServerPing_;
    /// <summary>
    ///网关服务器到游戏服的ping
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ToGameServerPing {
      get { return toGameServerPing_; }
      set {
        toGameServerPing_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GWS2C_Heartbeat);
    }

    public bool Equals(GWS2C_Heartbeat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Time != other.Time) return false;
      if (ServerTime != other.ServerTime) return false;
      if (ToGameServerPing != other.ToGameServerPing) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (ServerTime != 0L) hash ^= ServerTime.GetHashCode();
      if (ToGameServerPing != 0) hash ^= ToGameServerPing.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Time != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(Time);
      }
      if (ServerTime != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ServerTime);
      }
      if (ToGameServerPing != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(ToGameServerPing);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (ServerTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ServerTime);
      }
      if (ToGameServerPing != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ToGameServerPing);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(GWS2C_Heartbeat other) {
      if (other == null) {
        return;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      if (other.ServerTime != 0L) {
        ServerTime = other.ServerTime;
      }
      if (other.ToGameServerPing != 0) {
        ToGameServerPing = other.ToGameServerPing;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Time = input.ReadInt64();
            break;
          }
          case 16: {
            ServerTime = input.ReadInt64();
            break;
          }
          case 24: {
            ToGameServerPing = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///服务器返回角色下线消息[c#]
  /// </summary>
  public sealed partial class GWS2C_ReturnOffline : HHFramework.IProto, pb::IMessage<GWS2C_ReturnOffline> {
    private static readonly pb::MessageParser<GWS2C_ReturnOffline> _parser = new pb::MessageParser<GWS2C_ReturnOffline>(() => new GWS2C_ReturnOffline());
    public ushort ProtoId => ProtoIdDefine.Proto_GWS2C_ReturnOffline;
    public string ProtoEnName => "GWS2C_ReturnOffline";
    public ProtoCategory Category => ProtoCategory.GatewayServer2Client;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GWS2C_ReturnOffline> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGWS2CReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_ReturnOffline() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_ReturnOffline(GWS2C_ReturnOffline other) : this() {
      type_ = other.type_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_ReturnOffline Clone() {
      return new GWS2C_ReturnOffline(this);
    }

    /// <summary>Field number for the "Type" field.</summary>
    public const int TypeFieldNumber = 1;
    private global::HHFramework.Proto.OfflineType type_ = global::HHFramework.Proto.OfflineType.ServerMaintain;
    /// <summary>
    ///下线类型
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::HHFramework.Proto.OfflineType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as GWS2C_ReturnOffline);
    }

    public bool Equals(GWS2C_ReturnOffline other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Type != global::HHFramework.Proto.OfflineType.ServerMaintain) hash ^= Type.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Type != global::HHFramework.Proto.OfflineType.ServerMaintain) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Type);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Type != global::HHFramework.Proto.OfflineType.ServerMaintain) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(GWS2C_ReturnOffline other) {
      if (other == null) {
        return;
      }
      if (other.Type != global::HHFramework.Proto.OfflineType.ServerMaintain) {
        Type = other.Type;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Type = (global::HHFramework.Proto.OfflineType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///服务器返回配置列表[c#][lua]
  /// </summary>
  public sealed partial class GWS2C_ReturnGameServerConfig : HHFramework.IProto, pb::IMessage<GWS2C_ReturnGameServerConfig> {
    private static readonly pb::MessageParser<GWS2C_ReturnGameServerConfig> _parser = new pb::MessageParser<GWS2C_ReturnGameServerConfig>(() => new GWS2C_ReturnGameServerConfig());
    public ushort ProtoId => ProtoIdDefine.Proto_GWS2C_ReturnGameServerConfig;
    public string ProtoEnName => "GWS2C_ReturnGameServerConfig";
    public ProtoCategory Category => ProtoCategory.GatewayServer2Client;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GWS2C_ReturnGameServerConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoGWS2CReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_ReturnGameServerConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_ReturnGameServerConfig(GWS2C_ReturnGameServerConfig other) : this() {
      gameServerConfigList_ = other.gameServerConfigList_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GWS2C_ReturnGameServerConfig Clone() {
      return new GWS2C_ReturnGameServerConfig(this);
    }

    /// <summary>Field number for the "GameServerConfigList" field.</summary>
    public const int GameServerConfigListFieldNumber = 1;
    private static readonly pb::FieldCodec<global::HHFramework.Proto.GWS2C_ReturnGameServerConfig.Types.GWS2C_ReturnGameServerConfig_Item> _repeated_gameServerConfigList_codec
        = pb::FieldCodec.ForMessage(10, global::HHFramework.Proto.GWS2C_ReturnGameServerConfig.Types.GWS2C_ReturnGameServerConfig_Item.Parser);
    private readonly pbc::RepeatedField<global::HHFramework.Proto.GWS2C_ReturnGameServerConfig.Types.GWS2C_ReturnGameServerConfig_Item> gameServerConfigList_ = new pbc::RepeatedField<global::HHFramework.Proto.GWS2C_ReturnGameServerConfig.Types.GWS2C_ReturnGameServerConfig_Item>();
    /// <summary>
    ///配置表
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::HHFramework.Proto.GWS2C_ReturnGameServerConfig.Types.GWS2C_ReturnGameServerConfig_Item> GameServerConfigList {
      get { return gameServerConfigList_; }
    }

    public override bool Equals(object other) {
      return Equals(other as GWS2C_ReturnGameServerConfig);
    }

    public bool Equals(GWS2C_ReturnGameServerConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!gameServerConfigList_.Equals(other.gameServerConfigList_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= gameServerConfigList_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      gameServerConfigList_.WriteTo(output, _repeated_gameServerConfigList_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      size += gameServerConfigList_.CalculateSize(_repeated_gameServerConfigList_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(GWS2C_ReturnGameServerConfig other) {
      if (other == null) {
        return;
      }
      gameServerConfigList_.Add(other.gameServerConfigList_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            gameServerConfigList_.AddEntriesFrom(input, _repeated_gameServerConfigList_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the GWS2C_ReturnGameServerConfig message type.</summary>
    public static partial class Types {
      public sealed partial class GWS2C_ReturnGameServerConfig_Item : HHFramework.IProto, pb::IMessage<GWS2C_ReturnGameServerConfig_Item> {
        private static readonly pb::MessageParser<GWS2C_ReturnGameServerConfig_Item> _parser = new pb::MessageParser<GWS2C_ReturnGameServerConfig_Item>(() => new GWS2C_ReturnGameServerConfig_Item());
        public ushort ProtoId => ProtoIdDefine.Proto_GWS2C_ReturnGameServerConfig_Item;
        public string ProtoEnName => "GWS2C_ReturnGameServerConfig_Item";
        public ProtoCategory Category => ProtoCategory.GatewayServer2Client;
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<GWS2C_ReturnGameServerConfig_Item> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::HHFramework.Proto.GWS2C_ReturnGameServerConfig.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GWS2C_ReturnGameServerConfig_Item() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GWS2C_ReturnGameServerConfig_Item(GWS2C_ReturnGameServerConfig_Item other) : this() {
          configCode_ = other.configCode_;
          isOpen_ = other.isOpen_;
          param_ = other.param_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GWS2C_ReturnGameServerConfig_Item Clone() {
          return new GWS2C_ReturnGameServerConfig_Item(this);
        }

        /// <summary>Field number for the "ConfigCode" field.</summary>
        public const int ConfigCodeFieldNumber = 1;
        private string configCode_ = "";
        /// <summary>
        ///配置编号
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string ConfigCode {
          get { return configCode_; }
          set {
            configCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "IsOpen" field.</summary>
        public const int IsOpenFieldNumber = 2;
        private bool isOpen_;
        /// <summary>
        ///是否开启
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool IsOpen {
          get { return isOpen_; }
          set {
            isOpen_ = value;
          }
        }

        /// <summary>Field number for the "Param" field.</summary>
        public const int ParamFieldNumber = 3;
        private string param_ = "";
        /// <summary>
        ///参数
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Param {
          get { return param_; }
          set {
            param_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        public override bool Equals(object other) {
          return Equals(other as GWS2C_ReturnGameServerConfig_Item);
        }

        public bool Equals(GWS2C_ReturnGameServerConfig_Item other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (ConfigCode != other.ConfigCode) return false;
          if (IsOpen != other.IsOpen) return false;
          if (Param != other.Param) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        public override int GetHashCode() {
          int hash = 1;
          if (ConfigCode.Length != 0) hash ^= ConfigCode.GetHashCode();
          if (IsOpen != false) hash ^= IsOpen.GetHashCode();
          if (Param.Length != 0) hash ^= Param.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        public void WriteTo(pb::CodedOutputStream output) {
          if (ConfigCode.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(ConfigCode);
          }
          if (IsOpen != false) {
            output.WriteRawTag(16);
            output.WriteBool(IsOpen);
          }
          if (Param.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Param);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        public int CalculateSize() {
          int size = 0;
          if (ConfigCode.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ConfigCode);
          }
          if (IsOpen != false) {
            size += 1 + 1;
          }
          if (Param.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Param);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        public void MergeFrom(GWS2C_ReturnGameServerConfig_Item other) {
          if (other == null) {
            return;
          }
          if (other.ConfigCode.Length != 0) {
            ConfigCode = other.ConfigCode;
          }
          if (other.IsOpen != false) {
            IsOpen = other.IsOpen;
          }
          if (other.Param.Length != 0) {
            Param = other.Param;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                ConfigCode = input.ReadString();
                break;
              }
              case 16: {
                IsOpen = input.ReadBool();
                break;
              }
              case 26: {
                Param = input.ReadString();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
