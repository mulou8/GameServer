using LeagueSandbox.GameServer.Logic.Packets.PacketHandlers;

namespace LeagueSandbox.GameServer.Logic.Packets
{
    public class ResourceType : BasePacket
    {
        public ResourceType(uint playernetid, byte resourceType) : base(PacketCmd.PKT_S2C_ResourceType, playernetid)
        {
            buffer.Write((byte)resourceType);
        }
    }
}