using HouraiTeahouse.Serialization;

namespace HouraiTeahouse.Backroll {

public struct SyncRequestMessage : ISerializable {
  public uint RandomRequest;
  public byte RemoteEndpoint;

  public void Serialize<T>(ref T serializer) where T : struct, ISerializer {
    serializer.Write(RandomRequest);
    serializer.Write(RemoteEndpoint);
  }

  public void Deserialize<T>(ref T deserializer) where T : struct, IDeserializer {
    RandomRequest = deserializer.ReadUInt32();
    RemoteEndpoint = deserializer.ReadByte();
  }
}

}