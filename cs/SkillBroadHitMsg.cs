//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: org/SkillBroadHitMsg.proto
// Note: requires additional types generated from: PBVector3.proto
namespace pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkillBroadHitMsg")]
  public partial class SkillBroadHitMsg : global::ProtoBuf.IExtensible
  {
    public SkillBroadHitMsg() {}
    
    private long _playerId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"playerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long playerId
    {
      get { return _playerId; }
      set { _playerId = value; }
    }
    private int _skillId;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"skillId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int skillId
    {
      get { return _skillId; }
      set { _skillId = value; }
    }
    private int _hitId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"hitId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int hitId
    {
      get { return _hitId; }
      set { _hitId = value; }
    }
    private pb.PBVector3 _pos;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public pb.PBVector3 pos
    {
      get { return _pos; }
      set { _pos = value; }
    }
    private readonly global::System.Collections.Generic.List<long> _hiters = new global::System.Collections.Generic.List<long>();
    [global::ProtoBuf.ProtoMember(5, Name=@"hiters", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<long> hiters
    {
      get { return _hiters; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}