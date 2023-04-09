// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Proto_C2GWS.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace HHFramework.Proto {

  /// <summary>Holder for reflection information generated from Proto_C2GWS.proto</summary>
  public static partial class ProtoC2GWSReflection {

    #region Descriptor
    /// <summary>File descriptor for Proto_C2GWS.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtoC2GWSReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFQcm90b19DMkdXUy5wcm90bxIRSEhGcmFtZXdvcmsuUHJvdG8aElByb3Rv",
            "X0NvbW1vbi5wcm90byIkCg9DMkdXU19SZWdDbGllbnQSEQoJQWNjb3VudElk",
            "GAEgASgDIikKFkMyR1dTX0VudGVyU2NlbmVfQXBwbHkSDwoHU2NlbmVJZBgB",
            "IAEoBSIjChBDMkdXU19FbnRlclNjZW5lEg8KB1NjZW5lSWQYASABKAUiLQoP",
            "QzJHV1NfSGVhcnRiZWF0EgwKBFRpbWUYASABKAMSDAoEUGluZxgCIAEoBWIG",
            "cHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::HHFramework.Proto.ProtoCommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.C2GWS_RegClient), global::HHFramework.Proto.C2GWS_RegClient.Parser, new[]{ "AccountId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.C2GWS_EnterScene_Apply), global::HHFramework.Proto.C2GWS_EnterScene_Apply.Parser, new[]{ "SceneId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.C2GWS_EnterScene), global::HHFramework.Proto.C2GWS_EnterScene.Parser, new[]{ "SceneId" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::HHFramework.Proto.C2GWS_Heartbeat), global::HHFramework.Proto.C2GWS_Heartbeat.Parser, new[]{ "Time", "Ping" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///玩家向网关服务器注册客户端[c#]
  /// </summary>
  public sealed partial class C2GWS_RegClient : HHFramework.IProto, pb::IMessage<C2GWS_RegClient> {
    private static readonly pb::MessageParser<C2GWS_RegClient> _parser = new pb::MessageParser<C2GWS_RegClient>(() => new C2GWS_RegClient());
    public ushort ProtoId => ProtoIdDefine.Proto_C2GWS_RegClient;
    public string ProtoEnName => "C2GWS_RegClient";
    public ProtoCategory Category => ProtoCategory.Client2GatewayServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C2GWS_RegClient> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoC2GWSReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_RegClient() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_RegClient(C2GWS_RegClient other) : this() {
      accountId_ = other.accountId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_RegClient Clone() {
      return new C2GWS_RegClient(this);
    }

    /// <summary>Field number for the "AccountId" field.</summary>
    public const int AccountIdFieldNumber = 1;
    private long accountId_;
    /// <summary>
    ///玩家账号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long AccountId {
      get { return accountId_; }
      set {
        accountId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as C2GWS_RegClient);
    }

    public bool Equals(C2GWS_RegClient other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AccountId != other.AccountId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (AccountId != 0L) hash ^= AccountId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (AccountId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(AccountId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (AccountId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AccountId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(C2GWS_RegClient other) {
      if (other == null) {
        return;
      }
      if (other.AccountId != 0L) {
        AccountId = other.AccountId;
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
            AccountId = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///玩家向网关服务器发送进入场景申请消息
  /// </summary>
  public sealed partial class C2GWS_EnterScene_Apply : HHFramework.IProto, pb::IMessage<C2GWS_EnterScene_Apply> {
    private static readonly pb::MessageParser<C2GWS_EnterScene_Apply> _parser = new pb::MessageParser<C2GWS_EnterScene_Apply>(() => new C2GWS_EnterScene_Apply());
    public ushort ProtoId => ProtoIdDefine.Proto_C2GWS_EnterScene_Apply;
    public string ProtoEnName => "C2GWS_EnterScene_Apply";
    public ProtoCategory Category => ProtoCategory.Client2GatewayServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C2GWS_EnterScene_Apply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoC2GWSReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_EnterScene_Apply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_EnterScene_Apply(C2GWS_EnterScene_Apply other) : this() {
      sceneId_ = other.sceneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_EnterScene_Apply Clone() {
      return new C2GWS_EnterScene_Apply(this);
    }

    /// <summary>Field number for the "SceneId" field.</summary>
    public const int SceneIdFieldNumber = 1;
    private int sceneId_;
    /// <summary>
    ///场景编号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as C2GWS_EnterScene_Apply);
    }

    public bool Equals(C2GWS_EnterScene_Apply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SceneId != other.SceneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SceneId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SceneId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SceneId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(C2GWS_EnterScene_Apply other) {
      if (other == null) {
        return;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
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
            SceneId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///玩家向网关服务器发送进入场景消息
  /// </summary>
  public sealed partial class C2GWS_EnterScene : HHFramework.IProto, pb::IMessage<C2GWS_EnterScene> {
    private static readonly pb::MessageParser<C2GWS_EnterScene> _parser = new pb::MessageParser<C2GWS_EnterScene>(() => new C2GWS_EnterScene());
    public ushort ProtoId => ProtoIdDefine.Proto_C2GWS_EnterScene;
    public string ProtoEnName => "C2GWS_EnterScene";
    public ProtoCategory Category => ProtoCategory.Client2GatewayServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C2GWS_EnterScene> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoC2GWSReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_EnterScene() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_EnterScene(C2GWS_EnterScene other) : this() {
      sceneId_ = other.sceneId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_EnterScene Clone() {
      return new C2GWS_EnterScene(this);
    }

    /// <summary>Field number for the "SceneId" field.</summary>
    public const int SceneIdFieldNumber = 1;
    private int sceneId_;
    /// <summary>
    ///场景编号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int SceneId {
      get { return sceneId_; }
      set {
        sceneId_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as C2GWS_EnterScene);
    }

    public bool Equals(C2GWS_EnterScene other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SceneId != other.SceneId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (SceneId != 0) hash ^= SceneId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (SceneId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(SceneId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (SceneId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(SceneId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(C2GWS_EnterScene other) {
      if (other == null) {
        return;
      }
      if (other.SceneId != 0) {
        SceneId = other.SceneId;
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
            SceneId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///玩家向网关服务器发送心跳消息
  /// </summary>
  public sealed partial class C2GWS_Heartbeat : HHFramework.IProto, pb::IMessage<C2GWS_Heartbeat> {
    private static readonly pb::MessageParser<C2GWS_Heartbeat> _parser = new pb::MessageParser<C2GWS_Heartbeat>(() => new C2GWS_Heartbeat());
    public ushort ProtoId => ProtoIdDefine.Proto_C2GWS_Heartbeat;
    public string ProtoEnName => "C2GWS_Heartbeat";
    public ProtoCategory Category => ProtoCategory.Client2GatewayServer;
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<C2GWS_Heartbeat> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::HHFramework.Proto.ProtoC2GWSReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_Heartbeat() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_Heartbeat(C2GWS_Heartbeat other) : this() {
      time_ = other.time_;
      ping_ = other.ping_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public C2GWS_Heartbeat Clone() {
      return new C2GWS_Heartbeat(this);
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

    /// <summary>Field number for the "Ping" field.</summary>
    public const int PingFieldNumber = 2;
    private int ping_;
    /// <summary>
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Ping {
      get { return ping_; }
      set {
        ping_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as C2GWS_Heartbeat);
    }

    public bool Equals(C2GWS_Heartbeat other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Time != other.Time) return false;
      if (Ping != other.Ping) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (Ping != 0) hash ^= Ping.GetHashCode();
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
      if (Ping != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Ping);
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
      if (Ping != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Ping);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    public void MergeFrom(C2GWS_Heartbeat other) {
      if (other == null) {
        return;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      if (other.Ping != 0) {
        Ping = other.Ping;
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
            Ping = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code