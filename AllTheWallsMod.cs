using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace AllTheWalls
{
	public class AllTheWallsMod : Mod
	{
		// Allow harvesting of non harvestable via AllTheWallsGlobalWall
		internal NewWall[] harvestWalls = new NewWall[] {
			new NewWall(WallID.DirtUnsafe, "DirtUnsafe", "Dirt Wall (Unsafe)", "Dirt_Wall"),
			new NewWall(WallID.EbonstoneUnsafe, "EbonstoneUnsafe", "Ebonstone Wall (Unsafe)", "Ebonstone_Wall"),
			new NewWall(WallID.HellstoneBrickUnsafe, "HellstoneBrickUnsafe", "Hellstone Brick Wall (Unsafe)", "Hellstone_Brick_Wall"),
			new NewWall(WallID.MudUnsafe, "MudUnsafe", "Mud Wall (Unsafe)", "Mud_Wall"),
			new NewWall(WallID.PearlstoneBrickUnsafe, "PearlstoneBrickUnsafe", "Pearlstone Wall (Unsafe)", "Pearlstone_Wall"),
			new NewWall(WallID.SnowWallUnsafe, "SnowWallUnsafe", "Snow Wall (Unsafe)", "Snow_Wall"),
			new NewWall(WallID.AmethystUnsafe, "AmethystUnsafe", "Amethyst Stone Wall (Unsafe)", "Amethyst_Wall"),
			new NewWall(WallID.TopazUnsafe, "TopazUnsafe", "Topaz Stone Wall (Unsafe)", "Topaz_Wall"),
			new NewWall(WallID.SapphireUnsafe, "SapphireUnsafe", "Sapphire Stone Wall (Unsafe)", "Sapphire_Wall"),
			new NewWall(WallID.EmeraldUnsafe, "EmeraldUnsafe", "Emerald Stone Wall (Unsafe)", "Emerald_Wall"),
			new NewWall(WallID.RubyUnsafe, "RubyUnsafe", "Ruby Stone Wall (Unsafe)", "Ruby_Wall"),
			new NewWall(WallID.DiamondUnsafe, "DiamondUnsafe", "Diamond Stone Wall (Unsafe)", "Diamond_Wall"),
			new NewWall(WallID.CaveUnsafe, "CaveUnsafe", "Green Mossy Wall (Unsafe)", "Unique_Cave_Wall_1"),
			new NewWall(WallID.Cave2Unsafe, "Cave2Unsafe", "Brown Mossy Wall (Unsafe)", "Unique_Cave_Wall_2"),
			new NewWall(WallID.Cave3Unsafe, "Cave3Unsafe", "Red Mossy Wall (Unsafe)", "Unique_Cave_Wall_3"),
			new NewWall(WallID.Cave4Unsafe, "Cave4Unsafe", "Blue Mossy Wall (Unsafe)", "Unique_Cave_Wall_4"),
			new NewWall(WallID.Cave5Unsafe, "Cave5Unsafe", "Purple Mossy Wall (Unsafe)", "Unique_Cave_Wall_5"),
			new NewWall(WallID.Cave6Unsafe, "Cave6Unsafe", "Rocky Dirt Wall (Unsafe)", "Unique_Cave_Wall_6"),
			new NewWall(WallID.Cave7Unsafe, "Cave7Unsafe", "Old Stone Wall (Unsafe)", "Unique_Cave_Wall_7"),
			new NewWall(WallID.SpiderUnsafe, "SpiderUnsafe", "Spider Wall (Unsafe)", "Spider_Wall"),
			new NewWall(WallID.GrassUnsafe, "GrassUnsafe", "Grass Wall (Unsafe)", "Grass_Wall"),
			new NewWall(WallID.JungleUnsafe, "JungleUnsafe", "Jungle Wall (Unsafe)", "Jungle_Wall"),
			new NewWall(WallID.FlowerUnsafe, "FlowerUnsafe", "Flower Wall (Unsafe)", "Flower_Wall"),
			new NewWall(WallID.CorruptGrassUnsafe, "CorruptGrassUnsafe", "Corrupt Grass Wall (Unsafe)", "Corrupt_Grass_Wall"),
			new NewWall(WallID.HallowedGrassUnsafe, "HallowedGrassUnsafe", "Hallowed Grass Wall (Unsafe)", "Hallowed_Grass_Wall"),
			new NewWall(WallID.IceUnsafe, "IceUnsafe", "Ice Wall (Unsafe)", "Ice_Wall"),
			new NewWall(WallID.ObsidianBackUnsafe, "ObsidianBackUnsafe", "Obsidian Wall (Unsafe)", "Obsidian_Back_Wall"),
			new NewWall(WallID.MushroomUnsafe, "MushroomUnsafe", "Mushroom Wall (Unsafe)", "Mushroom_Wall"),
			new NewWall(WallID.CrimsonGrassUnsafe, "CrimsonGrassUnsafe", "Crimson Grass Wall (Unsafe)", "Crimson_Grass_Wall"),
			new NewWall(WallID.CrimstoneUnsafe, "CrimstoneUnsafe", "Crimstone Wall (Unsafe)", "Crimstone_Wall"),
			new NewWall(WallID.CaveWall, "CaveWall", "Cave Dirt Wall (Unsafe)", "Cave_Wall_1"),
			new NewWall(WallID.CaveWall2, "CaveWall2", "Rough Dirt Wall (Unsafe)", "Cave_Wall_2"),
			new NewWall(WallID.MarbleUnsafe, "MarbleUnsafe", "Marble Wall (Unsafe)", "Marble_Wall"),
			new NewWall(WallID.GraniteUnsafe, "GraniteUnsafe", "Granite Wall (Unsafe)", "Granite_Wall"),
			new NewWall(WallID.Cave8Unsafe, "Cave8Unsafe", "Craggy Stone Wall (Unsafe)", "Unique_Cave_Wall_8"),
			new NewWall(WallID.Sandstone, "Sandstone", "Sandstone Wall (Unsafe)", "Sandstone_Wall"),
			new NewWall(WallID.CorruptionUnsafe1, "CorruptionUnsafe1", "Corrupt Growth Wall (Unsafe)", "Corruption_Wall_1"),
			new NewWall(WallID.CorruptionUnsafe2, "CorruptionUnsafe2", "Corrupt Mass Wall (Unsafe)", "Corruption_Wall_2"),
			new NewWall(WallID.CorruptionUnsafe3, "CorruptionUnsafe3", "Corrupt Pustule Wall (Unsafe)", "Corruption_Wall_3"),
			new NewWall(WallID.CorruptionUnsafe4, "CorruptionUnsafe4", "Corrupt Tendril Wall (Unsafe)", "Corruption_Wall_4"),
			new NewWall(WallID.CrimsonUnsafe1, "CrimsonUnsafe1", "Crimson Crust Wall (Unsafe)", "Crimson_Wall_1"),
			new NewWall(WallID.CrimsonUnsafe2, "CrimsonUnsafe2", "Crimson Scab Wall (Unsafe)", "Crimson_Wall_1"),
			new NewWall(WallID.CrimsonUnsafe3, "CrimsonUnsafe3", "Crimson Teeth Wall (Unsafe)", "Crimson_Wall_1"),
			new NewWall(WallID.CrimsonUnsafe4, "CrimsonUnsafe4", "Crimson Blister Wall (Unsafe)", "Crimson_Wall_1"),
			new NewWall(WallID.DirtUnsafe1, "DirtUnsafe1", "Layered Dirt Wall (Unsafe)", "Dirt_Wall_1"),
			new NewWall(WallID.DirtUnsafe2, "DirtUnsafe2", "Crumbling Dirt Wall (Unsafe)", "Dirt_Wall_2"),
			new NewWall(WallID.DirtUnsafe3, "DirtUnsafe3", "Cracked Dirt Wall (Unsafe)", "Dirt_Wall_3"),
			new NewWall(WallID.DirtUnsafe4, "DirtUnsafe4", "Wavy Dirt Wall (Unsafe)", "Dirt_Wall_4"),
			new NewWall(WallID.HallowUnsafe1, "HallowUnsafe1", "Hallowed Prism Wall (Unsafe)", "Hallow_Wall_1"),
			new NewWall(WallID.HallowUnsafe2, "HallowUnsafe2", "Hallowed Cavern Wall (Unsafe)", "Hallow_Wall_2"),
			new NewWall(WallID.HallowUnsafe3, "HallowUnsafe3", "Hallowed Shard Wall (Unsafe)", "Hallow_Wall_3"),
			new NewWall(WallID.HallowUnsafe4, "HallowUnsafe4", "Hallowed Crystalline Wall (Unsafe)", "Hallow_Wall_4"),
			new NewWall(WallID.JungleUnsafe1, "JungleUnsafe1", "Lichen Stone Wall (Unsafe)", "Jungle_Wall_1"),
			new NewWall(WallID.JungleUnsafe2, "JungleUnsafe2", "Leafy Jungle Wall (Unsafe)", "Jungle_Wall_2"),
			new NewWall(WallID.JungleUnsafe3, "JungleUnsafe3", "Ivy Stone Wall (Unsafe)", "Jungle_Wall_3"),
			new NewWall(WallID.JungleUnsafe4, "JungleUnsafe4", "Jungle Vine Wall (Unsafe)", "Jungle_Wall_4"),
			new NewWall(WallID.LavaUnsafe1, "LavaUnsafe1", "Ember Wall (Unsafe)", "Lava_Wall_1"),
			new NewWall(WallID.LavaUnsafe2, "LavaUnsafe2", "Cinder Wall (Unsafe)", "Lava_Wall_2"),
			new NewWall(WallID.LavaUnsafe3, "LavaUnsafe3", "Magma Wall (Unsafe)", "Lava_Wall_3"),
			new NewWall(WallID.LavaUnsafe4, "LavaUnsafe4", "Smouldering Stone Wall (Unsafe)", "Lava_Wall_4"),
			new NewWall(WallID.RocksUnsafe1, "RocksUnsafe1", "Worn Stone Wall (Unsafe)", "Rocks_Wall_1"),
			new NewWall(WallID.RocksUnsafe2, "RocksUnsafe2", "Stalactite Stone Wall (Unsafe)", "Rocks_Wall_2"),
			new NewWall(WallID.RocksUnsafe3, "RocksUnsafe3", "Mottled Stone Wall (Unsafe)", "Rocks_Wall_3"),
			new NewWall(WallID.RocksUnsafe4, "RocksUnsafe4", "Fractured Stone Wall (Unsafe)", "Rocks_Wall_4"),
			new NewWall(WallID.HardenedSand, "HardenedSand", "Hardened Sand Wall (Unsafe)", "Hardened_Sand_Wall"),
			new NewWall(WallID.CorruptHardenedSand, "CorruptHardenedSand", "Hardened Ebonsand Wall (Unsafe)", "Hardened_Ebonsand_Wall"),
			new NewWall(WallID.CrimsonHardenedSand, "CrimsonHardenedSand", "Hardened Crimsand Wall (Unsafe)", "Hardened_Crimsand_Wall"),
			new NewWall(WallID.HallowHardenedSand, "HallowHardenedSand", "Hardened Pearlsand Wall (Unsafe)", "Hardened_Pearlsand_Wall"),
			new NewWall(WallID.CorruptSandstone, "CorruptSandstone", "Ebonsandstone Wall (Unsafe)", "Ebonsandstone_Wall"),
			new NewWall(WallID.CrimsonSandstone, "CrimsonSandstone", "Crimsandstone Wall (Unsafe)", "Crimsandstone_Wall"),
			new NewWall(WallID.HallowSandstone, "HallowSandstone", "Pearlsandstone Wall (Unsafe)", "Pearlsandstone_Wall"),
			new NewWall(WallID.DesertFossil, "DesertFossil", "Desert Fossil Wall (Unsafe)", "Desert_Fossil_Wall"),
			new NewWall(WallID.LivingWoodUnsafe, "LivingWoodUnsafe", "Living Wood Wall (Unsafe)", "Living_Wood_Wall"),
		};

		// New wall items that can only be obtained by converting the existing dropped wall. Allow conversion of safe to unsafe via recipes
		internal NewWall[] convertOnlyWalls = new NewWall[] {
			new NewWall(WallID.HiveUnsafe, "HiveUnsafe", "Hive Wall (Unsafe)", "Hive_Wall"),
			new NewWall(WallID.LihzahrdBrickUnsafe, "LihzahrdBrickUnsafe", "Lihzahrd Brick Wall (Unsafe)", "Lihzahrd_Brick_Wall"),
			new NewWall(WallID.BlueDungeonUnsafe, "BlueDungeonUnsafe", "Blue Brick Wall (Unsafe)", "Blue_Brick_Wall"),
			new NewWall(WallID.GreenDungeonUnsafe, "GreenDungeonUnsafe", "Green Brick Wall (Unsafe)", "Green_Brick_Wall"),
			new NewWall(WallID.PinkDungeonUnsafe, "PinkDungeonUnsafe", "Pink Brick Wall (Unsafe)", "Pink_Brick_Wall"),
			new NewWall(WallID.BlueDungeonSlabUnsafe, "BlueDungeonSlabUnsafe", "Blue Slab Wall (Unsafe)", "Blue_Slab_Wall"),
			new NewWall(WallID.BlueDungeonTileUnsafe, "BlueDungeonTileUnsafe", "Blue Tiled Wall (Unsafe)", "Blue_Tiled_Wall"),
			new NewWall(WallID.PinkDungeonSlabUnsafe, "PinkDungeonSlabUnsafe", "Pink Slab Wall (Unsafe)", "Pink_Slab_Wall"),
			new NewWall(WallID.PinkDungeonTileUnsafe, "PinkDungeonTileUnsafe", "Pink Tiled Wall (Unsafe)", "Pink_Tiled_Wall"),
			new NewWall(WallID.GreenDungeonSlabUnsafe, "GreenDungeonSlabUnsafe", "Green Slab Wall (Unsafe)", "Green_Slab_Wall"),
			new NewWall(WallID.GreenDungeonTileUnsafe, "GreenDungeonTileUnsafe", "Green Tiled Wall (Unsafe)", "Green_Tiled_Wall"),
			new NewWall(WallID.ObsidianBrickUnsafe, "ObsidianBrickUnsafe", "Obsidian Brick Wall (Unsafe)", "Obsidian_Brick_Wall"),
		};

		// Recipes to convert harvested walls to all varieties that drop that wall item
		internal ConvertWall[] convertToUnsafeWalls = new ConvertWall[] {
			new ConvertWall(ItemID.DirtWall,    WallID.DirtUnsafe),
			new ConvertWall(ItemID.DirtWall,    WallID.DirtUnsafe1),
			new ConvertWall(ItemID.DirtWall,    WallID.DirtUnsafe2),
			new ConvertWall(ItemID.DirtWall,    WallID.DirtUnsafe3),
			new ConvertWall(ItemID.DirtWall,    WallID.DirtUnsafe4),
			new ConvertWall(ItemID.GrassWall,   WallID.GrassUnsafe),
			new ConvertWall(ItemID.JungleWall,  WallID.JungleUnsafe),
			new ConvertWall(ItemID.JungleWall,  WallID.JungleUnsafe1),
			new ConvertWall(ItemID.JungleWall,  WallID.JungleUnsafe2),
			new ConvertWall(ItemID.JungleWall,  WallID.JungleUnsafe3),
			new ConvertWall(ItemID.JungleWall,  WallID.JungleUnsafe4),
			new ConvertWall(ItemID.FlowerWall,  WallID.FlowerUnsafe),
			new ConvertWall(ItemID.MushroomWall, WallID.MushroomUnsafe),
			new ConvertWall(ItemID.LihzahrdBrickWall, WallID.LihzahrdBrickUnsafe),
			new ConvertWall(ItemID.HellstoneBrickWall,  WallID.HellstoneBrickUnsafe),
			new ConvertWall(ItemID.HiveWall, WallID.HiveUnsafe),
			new ConvertWall(ItemID.MarbleWall,  WallID.MarbleUnsafe),
			new ConvertWall(ItemID.GraniteWall, WallID.GraniteUnsafe),
			new ConvertWall(ItemID.BlueBrickWall,  WallID.BlueDungeonUnsafe),
			new ConvertWall(ItemID.BlueSlabWall,  WallID.BlueDungeonSlabUnsafe),
			new ConvertWall(ItemID.BlueTiledWall,  WallID.BlueDungeonTileUnsafe),
			new ConvertWall(ItemID.PinkBrickWall, WallID.PinkDungeonUnsafe),
			new ConvertWall(ItemID.PinkSlabWall,  WallID.PinkDungeonSlabUnsafe),
			new ConvertWall(ItemID.PinkTiledWall, WallID.PinkDungeonTileUnsafe),
			new ConvertWall(ItemID.GreenBrickWall, WallID.GreenDungeonUnsafe),
			new ConvertWall(ItemID.GreenSlabWall,  WallID.GreenDungeonSlabUnsafe),
			new ConvertWall(ItemID.GreenTiledWall, WallID.GreenDungeonTileUnsafe),
			new ConvertWall(ItemID.ObsidianBrickWall, WallID.ObsidianBrickUnsafe),
			new ConvertWall(ItemID.GrassWall, WallID.CorruptGrassUnsafe),
			new ConvertWall(ItemID.FlowerWall, WallID.CorruptGrassUnsafe),
			new ConvertWall(ItemID.JungleWall,  WallID.CorruptGrassUnsafe),
			new ConvertWall(ItemID.GrassWall,  WallID.CrimsonGrassUnsafe),
			new ConvertWall(ItemID.FlowerWall,  WallID.CrimsonGrassUnsafe),
			new ConvertWall(ItemID.JungleWall, WallID.CrimsonGrassUnsafe),
			new ConvertWall(ItemID.GrassWall,  WallID.HallowedGrassUnsafe),
			new ConvertWall(ItemID.FlowerWall, WallID.HallowedGrassUnsafe),
			new ConvertWall(ItemID.JungleWall, WallID.HallowedGrassUnsafe),
			new ConvertWall(ItemID.StoneWall, WallID.PearlstoneBrickUnsafe),
			new ConvertWall(ItemID.StoneWall, WallID.EbonstoneUnsafe),
			new ConvertWall(ItemID.StoneWall, WallID.CrimstoneUnsafe),
		};

		internal IDictionary<int, int> mapOriginalWallToItemID;
		internal IDictionary<int, int> mapPlaceWallToItemID;

		public override void Load() {
			mapOriginalWallToItemID = new Dictionary<int, int>();
			mapPlaceWallToItemID = new Dictionary<int, int>();

			// These walls don't drop anything in Vanilla, they should now drop an item that places the unsafe. 
			foreach (var newWall in harvestWalls) {
				AllTheWallsItems item = new AllTheWallsItems(newWall.itemName, newWall.wallID, newWall.displayName, "AllTheWalls/ItemImages/" + newWall.textureName);
				AddContent(item);
				mapOriginalWallToItemID.Add(newWall.wallID, item.Item.type);
				mapPlaceWallToItemID.Add(newWall.wallID, item.Item.type);
			}

			// These walls should harvest the safe in Vanilla, but a recipe will allow for obtaining unsafe: hive, dungeon, etc
			foreach (var newWall in convertOnlyWalls) {
				AllTheWallsItems item = new AllTheWallsItems(newWall.itemName, newWall.wallID, newWall.displayName, "AllTheWalls/ItemImages/" + newWall.textureName);
				AddContent(item);
				mapPlaceWallToItemID.Add(newWall.wallID, item.Item.type);
			}
		}
	}
}
