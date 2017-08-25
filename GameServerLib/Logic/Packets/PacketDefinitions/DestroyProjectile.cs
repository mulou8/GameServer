using LeagueSandbox.GameServer.Logic.GameObjects;
using LeagueSandbox.GameServer.Logic.Packets.PacketHandlers;

namespace LeagueSandbox.GameServer.Logic.Packets
{
    public class DestroyProjectile : BasePacket
    {
        public DestroyProjectile(Projectile p) : base(PacketCmd.PKT_S2C_DestroyProjectile, p.NetId)
        {

        }
    }
}