//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: org/GetPlayerInfoMsg.proto
namespace pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GetPlayerInfoMsg")]
  public partial class GetPlayerInfoMsg : global::ProtoBuf.IExtensible
  {
    public GetPlayerInfoMsg() {}
    
    private long _playerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}