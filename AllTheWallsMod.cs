using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;

namespace AllTheWalls
{
	public class AllTheWallsMod : Mod
	{
		// Allow harvesting of non harvestable via AllTheWallsGlobalWall
		internal NewWall[] harvestWalls = new NewWall[] {
			new NewWall(WallID.DirtUnsafe, "DirtUnsafe", ItemID.DirtWall),
			new NewWall(WallID.EbonstoneUnsafe, "EbonstoneUnsafe", ItemID.EbonwoodWall),
			new NewWall(WallID.HellstoneBrickUnsafe, "HellstoneBrickUnsafe", ItemID.HellstoneBrickWall),
			new NewWall(WallID.MudUnsafe, "MudUnsafe", ItemID.MudWallEcho),
			new NewWall(WallID.PearlstoneBrickUnsafe, "PearlstoneBrickUnsafe", ItemID.PearlstoneEcho),
			new NewWall(WallID.SnowWallUnsafe, "SnowWallUnsafe", ItemID.SnowWallEcho),
			new NewWall(WallID.AmethystUnsafe, "AmethystUnsafe", ItemID.AmethystEcho),
			new NewWall(WallID.TopazUnsafe, "TopazUnsafe", ItemID.TopazEcho),
			new NewWall(WallID.SapphireUnsafe, "SapphireUnsafe", ItemID.SapphireEcho),
			new NewWall(WallID.EmeraldUnsafe, "EmeraldUnsafe",  ItemID.EmeraldEcho),
			new NewWall(WallID.RubyUnsafe, "RubyUnsafe",  ItemID.RubyEcho),
			new NewWall(WallID.DiamondUnsafe, "DiamondUnsafe", ItemID.DiamondEcho),
			new NewWall(WallID.CaveUnsafe, "CaveUnsafe", ItemID.Cave1Echo),
			new NewWall(WallID.Cave2Unsafe, "Cave2Unsafe", ItemID.Cave2Echo),
			new NewWall(WallID.Cave3Unsafe, "Cave3Unsafe", ItemID.Cave3Echo),
			new NewWall(WallID.Cave4Unsafe, "Cave4Unsafe", ItemID.Cave4Echo),
			new NewWall(WallID.Cave5Unsafe, "Cave5Unsafe", ItemID.Cave5Echo),
			new NewWall(WallID.Cave6Unsafe, "Cave6Unsafe", ItemID.Cave6Echo),
			new NewWall(WallID.Cave7Unsafe, "Cave7Unsafe", ItemID.Cave7Echo),
			new NewWall(WallID.SpiderUnsafe, "SpiderUnsafe", ItemID.SpiderWall),
			new NewWall(WallID.GrassUnsafe, "GrassUnsafe", ItemID.GrassWall),
			new NewWall(WallID.JungleUnsafe, "JungleUnsafe", ItemID.JungleWall),
			new NewWall(WallID.FlowerUnsafe, "FlowerUnsafe", ItemID.FlowerWall),
			new NewWall(WallID.CorruptGrassUnsafe, "CorruptGrassUnsafe", ItemID.CorruptGrassEcho),
			new NewWall(WallID.HallowedGrassUnsafe, "HallowedGrassUnsafe", ItemID.HallowedGrassEcho),
			new NewWall(WallID.IceUnsafe, "IceUnsafe", ItemID.IceEcho),
			new NewWall(WallID.ObsidianBackUnsafe, "ObsidianBackUnsafe", ItemID.ObsidianBackEcho),
			new NewWall(WallID.MushroomUnsafe, "MushroomUnsafe", ItemID.MushroomWall),
			new NewWall(WallID.CrimsonGrassUnsafe, "CrimsonGrassUnsafe", ItemID.CrimsonGrassEcho),
			new NewWall(WallID.CrimstoneUnsafe, "CrimstoneUnsafe", ItemID.CrimstoneEcho),
			new NewWall(WallID.CaveWall, "CaveWall", ItemID.CaveWall1Echo),
			new NewWall(WallID.CaveWall2, "CaveWall2", ItemID.CaveWall2Echo),
			new NewWall(WallID.MarbleUnsafe, "MarbleUnsafe", ItemID.MarbleWall),
			new NewWall(WallID.GraniteUnsafe, "GraniteUnsafe", ItemID.GraniteWall),
			new NewWall(WallID.Cave8Unsafe, "Cave8Unsafe", ItemID.Cave8Echo),
			new NewWall(WallID.Sandstone, "Sandstone",  ItemID.SandstoneWall),
			new NewWall(WallID.CorruptionUnsafe1, "CorruptionUnsafe1", ItemID.Corruption1Echo),
			new NewWall(WallID.CorruptionUnsafe2, "CorruptionUnsafe2", ItemID.Corruption2Echo),
			new NewWall(WallID.CorruptionUnsafe3, "CorruptionUnsafe3", ItemID.Corruption3Echo),
			new NewWall(WallID.CorruptionUnsafe4, "CorruptionUnsafe4", ItemID.Corruption4Echo),
			new NewWall(WallID.CrimsonUnsafe1, "CrimsonUnsafe1", ItemID.Crimson1Echo),
			new NewWall(WallID.CrimsonUnsafe2, "CrimsonUnsafe2", ItemID.Crimson2Echo),
			new NewWall(WallID.CrimsonUnsafe3, "CrimsonUnsafe3", ItemID.Crimson3Echo),
			new NewWall(WallID.CrimsonUnsafe4, "CrimsonUnsafe4", ItemID.Crimson4Echo),
			new NewWall(WallID.DirtUnsafe1, "DirtUnsafe1", ItemID.Dirt1Echo),
			new NewWall(WallID.DirtUnsafe2, "DirtUnsafe2", ItemID.Dirt2Echo),
			new NewWall(WallID.DirtUnsafe3, "DirtUnsafe3", ItemID.Dirt3Echo),
			new NewWall(WallID.DirtUnsafe4, "DirtUnsafe4", ItemID.Dirt4Echo),
			new NewWall(WallID.HallowUnsafe1, "HallowUnsafe1", ItemID.Hallow1Echo),
			new NewWall(WallID.HallowUnsafe2, "HallowUnsafe2", ItemID.Hallow2Echo),
			new NewWall(WallID.HallowUnsafe3, "HallowUnsafe3", ItemID.Hallow3Echo),
			new NewWall(WallID.HallowUnsafe4, "HallowUnsafe4", ItemID.Hallow4Echo),
			new NewWall(WallID.JungleUnsafe1, "JungleUnsafe1", ItemID.Jungle1Echo),
			new NewWall(WallID.JungleUnsafe2, "JungleUnsafe2", ItemID.Jungle2Echo),
			new NewWall(WallID.JungleUnsafe3, "JungleUnsafe3", ItemID.Jungle3Echo),
			new NewWall(WallID.JungleUnsafe4, "JungleUnsafe4", ItemID.Jungle4Echo),
			new NewWall(WallID.LavaUnsafe1, "LavaUnsafe1", ItemID.Lava1Echo),
			new NewWall(WallID.LavaUnsafe2, "LavaUnsafe2", ItemID.Lava2Echo),
			new NewWall(WallID.LavaUnsafe3, "LavaUnsafe3", ItemID.Lava3Echo),
			new NewWall(WallID.LavaUnsafe4, "LavaUnsafe4", ItemID.Lava4Echo),
			new NewWall(WallID.RocksUnsafe1, "RocksUnsafe1", ItemID.Rocks1Echo),
			new NewWall(WallID.RocksUnsafe2, "RocksUnsafe2", ItemID.Rocks2Echo),
			new NewWall(WallID.RocksUnsafe3, "RocksUnsafe3", ItemID.Rocks3Echo),
			new NewWall(WallID.RocksUnsafe4, "RocksUnsafe4", ItemID.Rocks4Echo),
			new NewWall(WallID.HardenedSand, "HardenedSand", ItemID.HardenedSandWall),
			new NewWall(WallID.CorruptHardenedSand, "CorruptHardenedSand", ItemID.CorruptHardenedSandWall),
			new NewWall(WallID.CrimsonHardenedSand, "CrimsonHardenedSand", ItemID.CrimsonHardenedSandWall),
			new NewWall(WallID.HallowHardenedSand, "HallowHardenedSand", ItemID.HallowHardenedSandWall),
			new NewWall(WallID.CorruptSandstone, "CorruptSandstone", ItemID.CorruptSandstoneWall),
			new NewWall(WallID.CrimsonSandstone, "CrimsonSandstone", ItemID.CrimsonSandstoneWall),
			new NewWall(WallID.HallowSandstone, "HallowSandstone", ItemID.HallowSandstoneWall),
			new NewWall(WallID.DesertFossil, "DesertFossil", ItemID.DesertFossilWall),
			new NewWall(WallID.LivingWoodUnsafe, "LivingWoodUnsafe", ItemID.LivingWoodWall),
		};

		// New wall items that can only be obtained by converting the existing dropped wall. Allow conversion of safe to unsafe via recipes
		internal NewWall[] convertOnlyWalls = new NewWall[] {
			new NewWall(WallID.HiveUnsafe, "HiveUnsafe", ItemID.HiveWall),
			new NewWall(WallID.LihzahrdBrickUnsafe, "LihzahrdBrickUnsafe", ItemID.LihzahrdBrickWall),
			new NewWall(WallID.BlueDungeonUnsafe, "BlueDungeonUnsafe", ItemID.BlueBrickWall),
			new NewWall(WallID.GreenDungeonUnsafe, "GreenDungeonUnsafe", ItemID.GreenBrickWall),
			new NewWall(WallID.PinkDungeonUnsafe, "PinkDungeonUnsafe", ItemID.PinkBrickWall),
			new NewWall(WallID.BlueDungeonSlabUnsafe, "BlueDungeonSlabUnsafe", ItemID.BlueSlabWall),
			new NewWall(WallID.BlueDungeonTileUnsafe, "BlueDungeonTileUnsafe", ItemID.BlueTiledWall),
			new NewWall(WallID.PinkDungeonSlabUnsafe, "PinkDungeonSlabUnsafe", ItemID.PinkSlabWall),
			new NewWall(WallID.PinkDungeonTileUnsafe, "PinkDungeonTileUnsafe", ItemID.PinkTiledWall),
			new NewWall(WallID.GreenDungeonSlabUnsafe, "GreenDungeonSlabUnsafe", ItemID.GreenSlabWall),
			new NewWall(WallID.GreenDungeonTileUnsafe, "GreenDungeonTileUnsafe", ItemID.GreenTiledWall),
			new NewWall(WallID.ObsidianBrickUnsafe, "ObsidianBrickUnsafe", ItemID.ObsidianBrickWall),
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
