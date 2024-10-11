using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using TerrariaLive4.CustomBuffs;

namespace TerrariaLive4.Players
{
  public class PermanentBuff : ModPlayer
  {
      public override void PreUpdate()
      {
          //Player.AddBuff(BuffID.Gravitation, 2);
           Player.AddBuff(ModContent.BuffType<GravDebuff>(), 2);
      }
  }
}