using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace TerrariaLive4.CustomBuffs
{
public class GravDebuff : ModBuff
  {
      public override void SetStaticDefaults()
      {
          Main.debuff[Type] = true;
          Main.buffNoTimeDisplay[Type] = false;
      }

      public override void Update(Player player, ref int buffIndex)
      {
          player.gravDir = -1;
          player.forcedGravity = 10;
      }
  }
}