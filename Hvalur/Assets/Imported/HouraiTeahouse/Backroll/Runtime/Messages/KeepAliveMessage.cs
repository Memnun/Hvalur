using HouraiTeahouse.Serialization;

namespace HouraiTeahouse.Backroll {

public struct SyncReplyMessage : ISerializable {
  public uint RandomReply;

  public void Serialize<T>(ref T serializer) where T : struct, ISerializer 
    => serializer.Write(RandomReply);
  public void Deserialize<T>(ref T deserializer) where T : struct, IDeserializer
    => RandomReply = deserializer.ReadUInt32();
}

}