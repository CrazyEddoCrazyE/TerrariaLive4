using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.WorldBuilding;


namespace TerrariaLive4.World
{
    public class GravityModWorld
    {
        public static void GeneratePlatforms()
        {
            // Get spawn coordinates
            int spawnX = Main.spawnTileX;
            int spawnY = Main.spawnTileY;
            int platformLength = 5;
            int platformHeight = 6;

            // Determine the height where the platform will be generated (1 tile above spawn)
            int platformY = spawnY - platformHeight;

            // Ensure platform is within world boundaries
            if (platformY > 0 && platformY < Main.worldSurface)
            {
                // Create a platform above the spawn point
                for (int x = spawnX - platformLength; x <= spawnX + platformLength; x++) // Adjust the range as needed
                {
                    // Set the tile type to wood or any other type you prefer
                    WorldGen.PlaceTile(x, platformY, 30, mute: true, forced: true, plr: -1, style: 0);
                }
            }

            
            for (int x = spawnX - platformLength; x <= spawnX + platformLength; x++)
            {
                for (int y = platformY - 10; y <= platformY - 1; y++)
                {
                    if (WorldGen.CanKillTile(x, y))
                    {
                        WorldGen.KillTile(x, y, noItem: true, effectOnly: false);
                    }
                }
            }
        }

        
    }
}