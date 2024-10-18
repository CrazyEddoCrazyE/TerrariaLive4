using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.WorldBuilding;
using TerrariaLive4.World;

namespace TerrariaLive4
{
    public class WorldGenSystem : ModSystem
    {
        #region ModifyWorldGenTasks
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref double totalWeight)
        {

            int FinalIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Final Cleanup"));
            if (FinalIndex != -1)
            {
                // Reallocate gems so rarity corresponds to depth
                int currentFinalIndex = FinalIndex;
                tasks.Insert(++currentFinalIndex, new PassLegacy("Forsaken Archive", (progress, config) =>
                {
                    GravityModWorld.GeneratePlatforms();
                }));
            }

        }
        #endregion
    } 
}