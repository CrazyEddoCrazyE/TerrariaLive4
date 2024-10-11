using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;
using System;

namespace TerrariaLive4.Items.Weapons.Melee // Where is your code locates
{
    public class LetaMosley : ModItem
    {
        public override void SetStaticDefaults()
        {
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1; // How many items need for research in Journey Mode
        }

        public override void SetDefaults()
        {
            // Visual properties
            Item.width = 74; // Width of an item sprite
            Item.height = 74; // Height of an item sprite
            Item.scale = 1f; // Multiplicator of item size, for example is you set this to 2f our sword will be biger twice. IMPORTANT: If you are using numbers with floating point, write "f" in their end, like 1.5f, 3.14f, 2.1278495f etc.
            Item.rare = ItemRarityID.Purple; // The color of item's name in game. Check https://terraria.wiki.gg/wiki/Rarity

            // Combat properties
            Item.damage = 1000000000; // Item damage
            Item.DamageType = DamageClass.Melee; // What type of damage item is deals, Melee, Ranged, Magic, Summon, Generic (takes bonuses from all damage multipliers), Default (doesn't take bonuses from any damage multipliers)
            // useTime and useAnimation often use the same value, but we'll see examples where they don't use the same values
            Item.useTime = 10; // How long the swing lasts in ticks (60 ticks = 1 second)
            Item.useAnimation = 10; // How long the swing animation lasts in ticks (60 ticks = 1 second)
            Item.knockBack = 20f; // How far the sword punches enemies, 20 is maximal value
            Item.autoReuse = true; // Can the item auto swing by holding the attack button

            // Other properties
            Item.value = Int32.MaxValue; // Item sell price in copper coins
            Item.useStyle = ItemUseStyleID.Swing; // This is how you're holding the weapon, visit https://terraria.wiki.gg/wiki/Use_Style_IDs for list of possible use styles
            Item.UseSound = SoundID.Item47; // What sound is played when using the item, all sounds can be found here - https://terraria.wiki.gg/wiki/Sound_IDs
        }

        // Creating item craft
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.Register();
        }
    }
}

