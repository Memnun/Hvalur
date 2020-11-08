using HouraiTeahouse.Networking;
using HouraiTeahouse.Serialization;
using UnityEngine;

namespace HouraiTeahouse.Backroll {

public struct QualityReportMessage : ISerializable {
  public byte FrameAdvantage;
  public uint Ping;

  public void Serialize<T>(ref T serializer) where T : struct, ISerializer {
    serializer.Write(FrameAdvantage);
    serializer.Write(Ping);
  }

  public void Deserialize<T>(ref T deserializer)  where T : struct, IDeserializer {
    FrameAdvantage = deserializer.ReadByte();
    Ping = deserializer.ReadUInt32();
  }
}

}