using HouraiTeahouse.Serialization;

namespace HouraiTeahouse.Backroll {

public struct QualityReplyMessage : ISerializable {
  public uint Pong;

  public void Serialize<T>(ref T serializer) where T : struct, ISerializer 
    => serializer.Write(Pong);
  public void Deserialize<T>(ref T deserializer) where T : struct, IDeserializer
    => Pong = deserializer.ReadUInt32();
}

}