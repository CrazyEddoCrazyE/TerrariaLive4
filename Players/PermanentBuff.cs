using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

public class PermanentBuff : ModPlayer
{
    public override void PreUpdate()
    {

        Player.AddBuff(BuffID.Gravitation, 2);
    }
}