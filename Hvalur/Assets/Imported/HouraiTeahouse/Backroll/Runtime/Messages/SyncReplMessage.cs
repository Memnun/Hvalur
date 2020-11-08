using HouraiTeahouse.Serialization;

namespace HouraiTeahouse.Backroll {

public struct KeepAliveMessage : ISerializable {
  public void Serialize<T>(ref T serializer) where T : struct, ISerializer {}
  public void Deserialize<T>(ref T deserializer) where T : struct, IDeserializer {}
}

}