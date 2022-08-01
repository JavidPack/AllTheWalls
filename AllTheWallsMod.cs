using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace AllTheWalls
{
	public class AllTheWallsMod : Mod
	{
		// Allow harvesting of non harvestable via AllTheWallsGlobalWall
		internal NewWall[] harvestWalls = new NewWall[] {
			new NewWall(WallID.DirtUnsafe, "DirtUnsafe", "Dirt Wall (Unsafe)", ItemID.DirtWall),
			new NewWall(WallID.EbonstoneUnsafe, "EbonstoneUnsafe", "Ebonstone Wall (Unsafe)", ItemID.EbonwoodWall),
			new NewWall(WallID.HellstoneBrickUnsafe, "HellstoneBrickUnsafe", "Hellstone Brick Wall (Unsafe)", ItemID.HellstoneBrickWall),
			new NewWall(WallID.MudUnsafe, "MudUnsafe", "Mud Wall (Unsafe)", ItemID.MudWallEcho),
			new NewWall(WallID.PearlstoneBrickUnsafe, "PearlstoneBrickUnsafe", "Pearlstone Wall (Unsafe)", ItemID.PearlstoneEcho),
			new NewWall(WallID.SnowWallUnsafe, "SnowWallUnsafe", "Snow Wall (Unsafe)", ItemID.SnowWallEcho),
			new NewWall(WallID.AmethystUnsafe, "AmethystUnsafe", "Amethyst Stone Wall (Unsafe)", ItemID.AmethystEcho),
			new NewWall(WallID.TopazUnsafe, "TopazUnsafe", "Topaz Stone Wall (Unsafe)", ItemID.TopazEcho),
			new NewWall(WallID.SapphireUnsafe, "SapphireUnsafe", "Sapphire Stone Wall (Unsafe)", ItemID.SapphireEcho),
			new NewWall(WallID.EmeraldUnsafe, "EmeraldUnsafe", "Emerald Stone Wall (Unsafe)",  ItemID.EmeraldEcho),
			new NewWall(WallID.RubyUnsafe, "RubyUnsafe", "Ruby Stone Wall (Unsafe)",  ItemID.RubyEcho),
			new NewWall(WallID.DiamondUnsafe, "DiamondUnsafe", "Diamond Stone Wall (Unsafe)", ItemID.DiamondEcho),
			new NewWall(WallID.CaveUnsafe, "CaveUnsafe", "Green Mossy Wall (Unsafe)", ItemID.Cave1Echo),
			new NewWall(WallID.Cave2Unsafe, "Cave2Unsafe", "Brown Mossy Wall (Unsafe)", ItemID.Cave2Echo),
			new NewWall(WallID.Cave3Unsafe, "Cave3Unsafe", "Red Mossy Wall (Unsafe)", ItemID.Cave3Echo),
			new NewWall(WallID.Cave4Unsafe, "Cave4Unsafe", "Blue Mossy Wall (Unsafe)", ItemID.Cave4Echo),
			new NewWall(WallID.Cave5Unsafe, "Cave5Unsafe", "Purple Mossy Wall (Unsafe)", ItemID.Cave5Echo),
			new NewWall(WallID.Cave6Unsafe, "Cave6Unsafe", "Rocky Dirt Wall (Unsafe)", ItemID.Cave6Echo),
			new NewWall(WallID.Cave7Unsafe, "Cave7Unsafe", "Old Stone Wall (Unsafe)", ItemID.Cave7Echo),
			new NewWall(WallID.SpiderUnsafe, "SpiderUnsafe", "Spider Wall (Unsafe)", ItemID.SpiderWall),
			new NewWall(WallID.GrassUnsafe, "GrassUnsafe", "Grass Wall (Unsafe)", ItemID.GrassWall),
			new NewWall(WallID.JungleUnsafe, "JungleUnsafe", "Jungle Wall (Unsafe)", ItemID.JungleWall),
			new NewWall(WallID.FlowerUnsafe, "FlowerUnsafe", "Flower Wall (Unsafe)", ItemID.FlowerWall),
			new NewWall(WallID.CorruptGrassUnsafe, "CorruptGrassUnsafe", "Corrupt Grass Wall (Unsafe)", ItemID.CorruptGrassEcho),
			new NewWall(WallID.HallowedGrassUnsafe, "HallowedGrassUnsafe", "Hallowed Grass Wall (Unsafe)", ItemID.HallowedGrassEcho),
			new NewWall(WallID.IceUnsafe, "IceUnsafe", "Ice Wall (Unsafe)", ItemID.IceEcho),
			new NewWall(WallID.ObsidianBackUnsafe, "ObsidianBackUnsafe", "Obsidian Wall (Unsafe)", ItemID.ObsidianBackEcho),
			new NewWall(WallID.MushroomUnsafe, "MushroomUnsafe", "Mushroom Wall (Unsafe)", ItemID.MushroomWall),
			new NewWall(WallID.CrimsonGrassUnsafe, "CrimsonGrassUnsafe", "Crimson Grass Wall (Unsafe)", ItemID.CrimsonGrassEcho),
			new NewWall(WallID.CrimstoneUnsafe, "CrimstoneUnsafe", "Crimstone Wall (Unsafe)", ItemID.CrimstoneEcho),
			new NewWall(WallID.CaveWall, "CaveWall", "Cave Dirt Wall (Unsafe)", ItemID.CaveWall1Echo),
			new NewWall(WallID.CaveWall2, "CaveWall2", "Rough Dirt Wall (Unsafe)", ItemID.CaveWall2Echo),
			new NewWall(WallID.MarbleUnsafe, "MarbleUnsafe", "Marble Wall (Unsafe)", ItemID.MarbleWall),
			new NewWall(WallID.GraniteUnsafe, "GraniteUnsafe", "Granite Wall (Unsafe)", ItemID.GraniteWall),
			new NewWall(WallID.Cave8Unsafe, "Cave8Unsafe", "Craggy Stone Wall (Unsafe)", ItemID.Cave8Echo),
			new NewWall(WallID.Sandstone, "Sandstone", "Sandstone Wall (Unsafe)",  ItemID.SandstoneWall),
			new NewWall(WallID.CorruptionUnsafe1, "CorruptionUnsafe1", "Corrupt Growth Wall (Unsafe)", ItemID.Corruption1Echo),
			new NewWall(WallID.CorruptionUnsafe2, "CorruptionUnsafe2", "Corrupt Mass Wall (Unsafe)", ItemID.Corruption2Echo),
			new NewWall(WallID.CorruptionUnsafe3, "CorruptionUnsafe3", "Corrupt Pustule Wall (Unsafe)", ItemID.Corruption3Echo),
			new NewWall(WallID.CorruptionUnsafe4, "CorruptionUnsafe4", "Corrupt Tendril Wall (Unsafe)", ItemID.Corruption4Echo),
			new NewWall(WallID.CrimsonUnsafe1, "CrimsonUnsafe1", "Crimson Crust Wall (Unsafe)", ItemID.Crimson1Echo),
			new NewWall(WallID.CrimsonUnsafe2, "CrimsonUnsafe2", "Crimson Scab Wall (Unsafe)", ItemID.Crimson2Echo),
			new NewWall(WallID.CrimsonUnsafe3, "CrimsonUnsafe3", "Crimson Teeth Wall (Unsafe)", ItemID.Crimson3Echo),
			new NewWall(WallID.CrimsonUnsafe4, "CrimsonUnsafe4", "Crimson Blister Wall (Unsafe)", ItemID.Crimson4Echo),
			new NewWall(WallID.DirtUnsafe1, "DirtUnsafe1", "Layered Dirt Wall (Unsafe)", ItemID.Dirt1Echo),
			new NewWall(WallID.DirtUnsafe2, "DirtUnsafe2", "Crumbling Dirt Wall (Unsafe)", ItemID.Dirt2Echo),
			new NewWall(WallID.DirtUnsafe3, "DirtUnsafe3", "Cracked Dirt Wall (Unsafe)", ItemID.Dirt3Echo),
			new NewWall(WallID.DirtUnsafe4, "DirtUnsafe4", "Wavy Dirt Wall (Unsafe)", ItemID.Dirt4Echo),
			new NewWall(WallID.HallowUnsafe1, "HallowUnsafe1", "Hallowed Prism Wall (Unsafe)", ItemID.Hallow1Echo),
			new NewWall(WallID.HallowUnsafe2, "HallowUnsafe2", "Hallowed Cavern Wall (Unsafe)", ItemID.Hallow2Echo),
			new NewWall(WallID.HallowUnsafe3, "HallowUnsafe3", "Hallowed Shard Wall (Unsafe)", ItemID.Hallow3Echo),
			new NewWall(WallID.HallowUnsafe4, "HallowUnsafe4", "Hallowed Crystalline Wall (Unsafe)", ItemID.Hallow4Echo),
			new NewWall(WallID.JungleUnsafe1, "JungleUnsafe1", "Lichen Stone Wall (Unsafe)", ItemID.Jungle1Echo),
			new NewWall(WallID.JungleUnsafe2, "JungleUnsafe2", "Leafy Jungle Wall (Unsafe)", ItemID.Jungle2Echo),
			new NewWall(WallID.JungleUnsafe3, "JungleUnsafe3", "Ivy Stone Wall (Unsafe)", ItemID.Jungle3Echo),
			new NewWall(WallID.JungleUnsafe4, "JungleUnsafe4", "Jungle Vine Wall (Unsafe)", ItemID.Jungle4Echo),
			new NewWall(WallID.LavaUnsafe1, "LavaUnsafe1", "Ember Wall (Unsafe)", ItemID.Lava1Echo),
			new NewWall(WallID.LavaUnsafe2, "LavaUnsafe2", "Cinder Wall (Unsafe)", ItemID.Lava2Echo),
			new NewWall(WallID.LavaUnsafe3, "LavaUnsafe3", "Magma Wall (Unsafe)", ItemID.Lava3Echo),
			new NewWall(WallID.LavaUnsafe4, "LavaUnsafe4", "Smouldering Stone Wall (Unsafe)", ItemID.Lava4Echo),
			new NewWall(WallID.RocksUnsafe1, "RocksUnsafe1", "Worn Stone Wall (Unsafe)", ItemID.Rocks1Echo),
			new NewWall(WallID.RocksUnsafe2, "RocksUnsafe2", "Stalactite Stone Wall (Unsafe)", ItemID.Rocks2Echo),
			new NewWall(WallID.RocksUnsafe3, "RocksUnsafe3", "Mottled Stone Wall (Unsafe)", ItemID.Rocks3Echo),
			new NewWall(WallID.RocksUnsafe4, "RocksUnsafe4", "Fractured Stone Wall (Unsafe)", ItemID.Rocks4Echo),
			new NewWall(WallID.HardenedSand, "HardenedSand", "Hardened Sand Wall (Unsafe)", ItemID.HardenedSandWall),
			new NewWall(WallID.CorruptHardenedSand, "CorruptHardenedSand", "Hardened Ebonsand Wall (Unsafe)", ItemID.CorruptHardenedSandWall),
			new NewWall(WallID.CrimsonHardenedSand, "CrimsonHardenedSand", "Hardened Crimsand Wall (Unsafe)", ItemID.CrimsonHardenedSandWall),
			new NewWall(WallID.HallowHardenedSand, "HallowHardenedSand", "Hardened Pearlsand Wall (Unsafe)", ItemID.HallowHardenedSandWall),
			new NewWall(WallID.CorruptSandstone, "CorruptSandstone", "Ebonsandstone Wall (Unsafe)", ItemID.CorruptSandstoneWall),
			new NewWall(WallID.CrimsonSandstone, "CrimsonSandstone", "Crimsandstone Wall (Unsafe)", ItemID.CrimsonSandstoneWall),
			new NewWall(WallID.HallowSandstone, "HallowSandstone", "Pearlsandstone Wall (Unsafe)", ItemID.HallowSandstoneWall),
			new NewWall(WallID.DesertFossil, "DesertFossil", "Desert Fossil Wall (Unsafe)", ItemID.DesertFossilWall),
			new NewWall(WallID.LivingWoodUnsafe, "LivingWoodUnsafe", "Living Wood Wall (Unsafe)", ItemID.LivingWoodWall),
		};

		// New wall items that can only be obtained by converting the existing dropped wall. Allow conversion of safe to unsafe via recipes
		internal NewWall[] convertOnlyWalls = new NewWall[] {
			new NewWall(WallID.HiveUnsafe, "HiveUnsafe", "Hive Wall (Unsafe)", ItemID.HiveWall),
			new NewWall(WallID.LihzahrdBrickUnsafe, "LihzahrdBrickUnsafe", "Lihzahrd Brick Wall (Unsafe)", ItemID.LihzahrdBrickWall),
			new NewWall(WallID.BlueDungeonUnsafe, "BlueDungeonUnsafe", "Blue Brick Wall (Unsafe)", ItemID.BlueBrickWall),
			new NewWall(WallID.GreenDungeonUnsafe, "GreenDungeonUnsafe", "Green Brick Wall (Unsafe)", ItemID.GreenBrickWall),
			new NewWall(WallID.PinkDungeonUnsafe, "PinkDungeonUnsafe", "Pink Brick Wall (Unsafe)", ItemID.PinkBrickWall),
			new NewWall(WallID.BlueDungeonSlabUnsafe, "BlueDungeonSlabUnsafe", "Blue Slab Wall (Unsafe)", ItemID.BlueSlabWall),
			new NewWall(WallID.BlueDungeonTileUnsafe, "BlueDungeonTileUnsafe", "Blue Tiled Wall (Unsafe)", ItemID.BlueTiledWall),
			new NewWall(WallID.PinkDungeonSlabUnsafe, "PinkDungeonSlabUnsafe", "Pink Slab Wall (Unsafe)", ItemID.PinkSlabWall),
			new NewWall(WallID.PinkDungeonTileUnsafe, "PinkDungeonTileUnsafe", "Pink Tiled Wall (Unsafe)", ItemID.PinkTiledWall),
			new NewWall(WallID.GreenDungeonSlabUnsafe, "GreenDungeonSlabUnsafe", "Green Slab Wall (Unsafe)", ItemID.GreenSlabWall),
			new NewWall(WallID.GreenDungeonTileUnsafe, "GreenDungeonTileUnsafe", "Green Tiled Wall (Unsafe)", ItemID.GreenTiledWall),
			new NewWall(WallID.ObsidianBrickUnsafe, "ObsidianBrickUnsafe", "Obsidian Brick Wall (Unsafe)", ItemID.ObsidianBrickWall),
		};

		// Recipes to convert harvested walls to all varieties that drop that wall item
		internal ConvertWall[] convertToUnsafeWalls = new ConvertWall[] {
			new ConvertWall(ItemID.DirtWall,    WallID.DirtUnsafe),
			new ConvertWall(ItemID.Dirt1Echo,    WallID.DirtUnsafe1),
			new ConvertWall(ItemID.Dirt2Echo,    WallID.DirtUnsafe2),
			new ConvertWall(ItemID.Dirt3Echo,    WallID.DirtUnsafe3),
			new ConvertWall(ItemID.Dirt4Echo,    WallID.DirtUnsafe4),
			new ConvertWall(ItemID.GrassWall,   WallID.GrassUnsafe),
			new ConvertWall(ItemID.JungleWall,  WallID.JungleUnsafe),
			new ConvertWall(ItemID.Jungle1Echo,  WallID.JungleUnsafe1),
			new ConvertWall(ItemID.Jungle2Echo,  WallID.JungleUnsafe2),
			new ConvertWall(ItemID.Jungle3Echo,  WallID.JungleUnsafe3),
			new ConvertWall(ItemID.Jungle4Echo,  WallID.JungleUnsafe4),
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
			new ConvertWall(ItemID.CorruptGrassEcho, WallID.CorruptGrassUnsafe),
			new ConvertWall(ItemID.HallowedGrassEcho,  WallID.HallowedGrassUnsafe),
			new ConvertWall(ItemID.CrimsonGrassEcho,  WallID.CrimsonGrassUnsafe),
			new ConvertWall(ItemID.PearlstoneEcho, WallID.PearlstoneBrickUnsafe),
			new ConvertWall(ItemID.EbonstoneEcho, WallID.EbonstoneUnsafe),
			new ConvertWall(ItemID.CrimstoneEcho, WallID.CrimstoneUnsafe),
			new ConvertWall(ItemID.MudWallEcho, WallID.MudUnsafe),
			new ConvertWall(ItemID.SnowWallEcho, WallID.SnowWallUnsafe),
			new ConvertWall(ItemID.AmethystEcho, WallID.AmethystUnsafe),
			new ConvertWall(ItemID.TopazEcho, WallID.TopazUnsafe),
			new ConvertWall(ItemID.SapphireEcho, WallID.SapphireUnsafe),
			new ConvertWall(ItemID.EmeraldEcho, WallID.EmeraldUnsafe),
			new ConvertWall(ItemID.RubyEcho, WallID.RubyUnsafe),
			new ConvertWall(ItemID.DiamondEcho, WallID.DiamondUnsafe),
			new ConvertWall(ItemID.Cave1Echo, WallID.CaveUnsafe),
			new ConvertWall(ItemID.Cave2Echo, WallID.Cave2Unsafe),
			new ConvertWall(ItemID.Cave3Echo, WallID.Cave3Unsafe),
			new ConvertWall(ItemID.Cave4Echo, WallID.Cave4Unsafe),
			new ConvertWall(ItemID.Cave5Echo, WallID.Cave5Unsafe),
			new ConvertWall(ItemID.Cave6Echo, WallID.Cave6Unsafe),
			new ConvertWall(ItemID.Cave7Echo, WallID.Cave7Unsafe),
			new ConvertWall(ItemID.Cave8Echo, WallID.Cave8Unsafe),
			new ConvertWall(ItemID.SpiderEcho, WallID.SpiderUnsafe),
			new ConvertWall(ItemID.IceEcho, WallID.IceUnsafe),
			new ConvertWall(ItemID.ObsidianBackEcho, WallID.ObsidianBackUnsafe),
			new ConvertWall(ItemID.CaveWall1Echo, WallID.CaveWall),
			new ConvertWall(ItemID.CaveWall2Echo, WallID.CaveWall2),
			new ConvertWall(ItemID.SandstoneWall, WallID.Sandstone),
			new ConvertWall(ItemID.Corruption1Echo, WallID.CorruptionUnsafe1),
			new ConvertWall(ItemID.Corruption2Echo, WallID.CorruptionUnsafe2),
			new ConvertWall(ItemID.Corruption3Echo, WallID.CorruptionUnsafe3),
			new ConvertWall(ItemID.Corruption4Echo, WallID.CorruptionUnsafe4),
			new ConvertWall(ItemID.Crimson1Echo, WallID.CrimsonUnsafe1),
			new ConvertWall(ItemID.Crimson2Echo, WallID.CrimsonUnsafe2),
			new ConvertWall(ItemID.Crimson3Echo, WallID.CrimsonUnsafe3),
			new ConvertWall(ItemID.Crimson4Echo, WallID.CrimsonUnsafe4),
			new ConvertWall(ItemID.Hallow1Echo, WallID.HallowUnsafe1),
			new ConvertWall(ItemID.Hallow2Echo, WallID.HallowUnsafe2),
			new ConvertWall(ItemID.Hallow3Echo, WallID.HallowUnsafe3),
			new ConvertWall(ItemID.Hallow4Echo, WallID.HallowUnsafe4),
			new ConvertWall(ItemID.Lava1Echo, WallID.LavaUnsafe1),
			new ConvertWall(ItemID.Lava2Echo, WallID.LavaUnsafe2),
			new ConvertWall(ItemID.Lava3Echo, WallID.LavaUnsafe3),
			new ConvertWall(ItemID.Lava4Echo, WallID.LavaUnsafe4),
			new ConvertWall(ItemID.Rocks1Echo, WallID.RocksUnsafe1),
			new ConvertWall(ItemID.Rocks2Echo, WallID.RocksUnsafe2),
			new ConvertWall(ItemID.Rocks3Echo, WallID.RocksUnsafe3),
			new ConvertWall(ItemID.Rocks4Echo, WallID.RocksUnsafe4),
			new ConvertWall(ItemID.HardenedSandWall, WallID.HardenedSand),
			new ConvertWall(ItemID.CorruptHardenedSandWall, WallID.CorruptHardenedSand),
			new ConvertWall(ItemID.CrimsonHardenedSandWall, WallID.CrimsonHardenedSand),
			new ConvertWall(ItemID.HallowHardenedSandWall, WallID.HallowHardenedSand),
			new ConvertWall(ItemID.CorruptSandstoneWall, WallID.CorruptSandstone),
			new ConvertWall(ItemID.CrimsonSandstoneWall, WallID.CrimsonSandstone),
			new ConvertWall(ItemID.HallowSandstoneWall, WallID.HallowSandstone),
			new ConvertWall(ItemID.DesertFossilWall, WallID.DesertFossil),
			new ConvertWall(ItemID.LivingWoodWall, WallID.LivingWoodUnsafe),
		};

		internal IDictionary<int, int> mapOriginalWallToItemID;
		internal IDictionary<int, int> mapPlaceWallToItemID;

		public override void Load() {
			mapOriginalWallToItemID = new Dictionary<int, int>();
			mapPlaceWallToItemID = new Dictionary<int, int>();

			// TODO: Some other mods add unsafe wall items, cluttering things. How should this be addressed? Have those mods detect this mod?
			// These walls don't drop anything in Vanilla, they should now drop an item that places the unsafe. 
			foreach (var newWall in harvestWalls) {
				AllTheWallsItems item = new AllTheWallsItems(newWall.itemName, newWall.wallID, newWall.displayName, newWall.textureName);
				AddContent(item);
				mapOriginalWallToItemID.Add(newWall.wallID, item.Item.type);
				mapPlaceWallToItemID.Add(newWall.wallID, item.Item.type);
			}

			// These walls should harvest the safe in Vanilla, but a recipe will allow for obtaining unsafe: hive, dungeon, etc
			foreach (var newWall in convertOnlyWalls) {
				AllTheWallsItems item = new AllTheWallsItems(newWall.itemName, newWall.wallID, newWall.displayName, newWall.textureName);
				AddContent(item);
				mapPlaceWallToItemID.Add(newWall.wallID, item.Item.type);
			}
		}
	}
}
