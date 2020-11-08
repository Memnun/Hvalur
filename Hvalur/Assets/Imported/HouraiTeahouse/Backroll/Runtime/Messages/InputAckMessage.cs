using HouraiTeahouse.Serialization; 

namespace HouraiTeahouse.Backroll {

public struct InputAckMessage : ISerializable {
  public int AckFrame;

  public void Serialize<T>(ref T serializer) where T : struct, ISerializer 
    => serializer.Write(AckFrame);
  public void Deserialize<T>(ref T deserializer) where T : struct, IDeserializer
    => AckFrame = deserializer.ReadInt32();
}

}