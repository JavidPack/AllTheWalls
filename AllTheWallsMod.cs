using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AllTheWalls
{
	class NewWall
	{
		public int wallID; // id of wall that drops this item
		public string displayName; // name displayed to player
		public string itemName; // name for records, don't change between releases
		public string textureName; // texture name

		public NewWall(byte wallID, string itemName, string displayName, string textureName)
		{
			this.wallID = wallID;
			this.itemName = itemName;
			this.displayName = displayName;
			this.textureName = textureName;
		}
	}

	class ConvertWall
	{
		//	internal int originalWallID;
		internal int originalWallItemID;
		internal int newWallID;

		public ConvertWall(short originalWallItemID, /*byte originalWallID,*/ byte newWallID)
		{
			this.originalWallItemID = originalWallItemID;
			//	this.originalWallID = originalWallID;
			this.newWallID = newWallID;
		}
	}

	// Allow harvesting of non harvestable
	// Allow conversion of safe to unsafe 

	public class AllTheWallsMod : Mod
	{
		NewWall[] harvestWalls = new NewWall[] {
			new NewWall(WallID.MudUnsafe, "MudUnsafe", "Mud (Unsafe)", "Mud_Wall"),
			new NewWall(WallID.SnowWallUnsafe, "SnowWallUnsafe", "Snow Wall (Unsafe)", "Snow_Wall"),
			new NewWall(WallID.IceUnsafe, "IceUnsafe", "Ice Wall (Unsafe)", "Ice_Wall"),
			new NewWall(WallID.SpiderUnsafe, "SpiderUnsafe", "Spider Wall (Unsafe)", "Spider_Wall"),
			new NewWall(WallID.ObsidianBackUnsafe, "ObsidianBackUnsafe", "Obsidian Back Wall (Unsafe)", "Obsidian_Back_Wall"),
			new NewWall(WallID.AmethystUnsafe, "AmethystUnsafe", "Amethyst Wall (Unsafe)", "Amethyst_Wall"),
			new NewWall(WallID.TopazUnsafe, "TopazUnsafe", "Topaz Wall (Unsafe)", "Topaz_Wall"),
			new NewWall(WallID.SapphireUnsafe, "SapphireUnsafe", "Sapphire Wall (Unsafe)", "Sapphire_Wall"),
			new NewWall(WallID.EmeraldUnsafe, "EmeraldUnsafe", "Emerald Wall (Unsafe)", "Emerald_Wall"),
			new NewWall(WallID.RubyUnsafe, "RubyUnsafe", "Ruby Wall (Unsafe)", "Ruby_Wall"),
			new NewWall(WallID.DiamondUnsafe, "DiamondUnsafe", "Diamond Wall (Unsafe)", "Diamond_Wall"),
			new NewWall(WallID.CaveUnsafe, "CaveUnsafe", "Cave Wall 1 (Unsafe)", "Unique_Cave_Wall_1"),
			new NewWall(WallID.Cave2Unsafe, "Cave2Unsafe", "Cave Wall 2 (Unsafe)", "Unique_Cave_Wall_2"),
			new NewWall(WallID.Cave3Unsafe, "Cave3Unsafe", "Cave Wall 3 (Unsafe)", "Unique_Cave_Wall_3"),
			new NewWall(WallID.Cave4Unsafe, "Cave4Unsafe", "Cave Wall 4 (Unsafe)", "Unique_Cave_Wall_4"),
			new NewWall(WallID.Cave5Unsafe, "Cave5Unsafe", "Cave Wall 5 (Unsafe)", "Unique_Cave_Wall_5"),
			new NewWall(WallID.Cave6Unsafe, "Cave6Unsafe", "Cave Wall 6 (Unsafe)", "Unique_Cave_Wall_6"),
			new NewWall(WallID.Cave7Unsafe, "Cave7Unsafe", "Cave Wall 7 (Unsafe)", "Unique_Cave_Wall_7"),
			new NewWall(WallID.Cave8Unsafe, "Cave8Unsafe", "Cave Wall 8 (Unsafe)", "Unique_Cave_Wall_8"),
			new NewWall(WallID.CaveWall, "CaveWall", "Cave Wall 9 (Unsafe)", "Cave_Wall_1"),
			new NewWall(WallID.CaveWall2, "CaveWall2", "Cave Wall 10 (Unsafe)", "Cave_Wall_2"),
			new NewWall(WallID.DirtUnsafe1, "DirtUnsafe1", "Dirt Wall 1 (Unsafe)", "Dirt_Wall_1"),
			new NewWall(WallID.DirtUnsafe2, "DirtUnsafe2", "Dirt Wall 2 (Unsafe)", "Dirt_Wall_2"),
			new NewWall(WallID.DirtUnsafe3,"DirtUnsafe3", "Dirt Wall 3 (Unsafe)", "Dirt_Wall_3"),
			new NewWall(WallID.DirtUnsafe4, "DirtUnsafe4", "Dirt Wall 4 (Unsafe)", "Dirt_Wall_4"),
			new NewWall(WallID.DirtUnsafe, "DirtUnsafe", "Dirt Wall 5 (Unsafe)", "Dirt_Wall"),
			new NewWall(WallID.RocksUnsafe1,"RocksUnsafe1", "Rocks Wall 1 (Unsafe)", "Rocks_Wall_1"),
			new NewWall(WallID.RocksUnsafe2,"RocksUnsafe2", "Rocks Wall 2 (Unsafe)", "Rocks_Wall_2"),
			new NewWall(WallID.RocksUnsafe3,"RocksUnsafe3", "Rocks Wall 3 (Unsafe)", "Rocks_Wall_3"),
			new NewWall(WallID.RocksUnsafe4,"RocksUnsafe4", "Rocks Wall 4 (Unsafe)", "Rocks_Wall_4"),
			new NewWall(WallID.CorruptionUnsafe1, "CorruptionUnsafe1", "Corruption Wall 1 (Unsafe)", "Corruption_Wall_1"),
			new NewWall(WallID.CorruptionUnsafe2, "CorruptionUnsafe2", "Corruption Wall 2 (Unsafe)", "Corruption_Wall_2"),
			new NewWall(WallID.CorruptionUnsafe3, "CorruptionUnsafe3", "Corruption Wall 3 (Unsafe)", "Corruption_Wall_3"),
			new NewWall(WallID.CorruptionUnsafe4, "CorruptionUnsafe4", "Corruption Wall 4 (Unsafe)", "Corruption_Wall_4"),
			new NewWall(WallID.CrimsonUnsafe1, "CrimsonUnsafe1", "Crimson Wall 1 (Unsafe)", "Crimson_Wall_1"),
			new NewWall(WallID.CrimsonUnsafe2, "CrimsonUnsafe2", "Crimson Wall 2 (Unsafe)", "Crimson_Wall_1"),
			new NewWall(WallID.CrimsonUnsafe3, "CrimsonUnsafe3", "Crimson Wall 3 (Unsafe)", "Crimson_Wall_1"),
			new NewWall(WallID.CrimsonUnsafe4, "CrimsonUnsafe4", "Crimson Wall 4 (Unsafe)", "Crimson_Wall_1"),
			new NewWall(WallID.HallowUnsafe1,"HallowUnsafe1", "Hallow Wall 1 (Unsafe)", "Hallow_Wall_1"),
			new NewWall(WallID.HallowUnsafe2,"HallowUnsafe2", "Hallow Wall 2 (Unsafe)", "Hallow_Wall_2"),
			new NewWall(WallID.HallowUnsafe3,"HallowUnsafe3", "Hallow Wall 3 (Unsafe)", "Hallow_Wall_3"),
			new NewWall(WallID.HallowUnsafe4,"HallowUnsafe4", "Hallow Wall 4 (Unsafe)", "Hallow_Wall_4"),
			new NewWall(WallID.JungleUnsafe1,"JungleUnsafe1", "Jungle Wall 1 (Unsafe)", "Jungle_Wall_1"),
			new NewWall(WallID.JungleUnsafe2,"JungleUnsafe2", "Jungle Wall 2 (Unsafe)", "Jungle_Wall_2"),
			new NewWall(WallID.JungleUnsafe3,"JungleUnsafe3", "Jungle Wall 3 (Unsafe)", "Jungle_Wall_3"),
			new NewWall(WallID.JungleUnsafe4,"JungleUnsafe4", "Jungle Wall 4 (Unsafe)", "Jungle_Wall_4"),
			new NewWall(WallID.JungleUnsafe, "JungleUnsafe", "Jungle Wall 5 (Unsafe)", "Jungle_Wall"),
			new NewWall(WallID.LavaUnsafe1, "LavaUnsafe1", "Lava Wall 1 (Unsafe)", "Lava_Wall_1"),
			new NewWall(WallID.LavaUnsafe2, "LavaUnsafe2", "Lava Wall 2 (Unsafe)", "Lava_Wall_2"),
			new NewWall(WallID.LavaUnsafe3, "LavaUnsafe3", "Lava Wall 3 (Unsafe)", "Lava_Wall_3"),
			new NewWall(WallID.LavaUnsafe4, "LavaUnsafe4", "Lava Wall 4 (Unsafe)", "Lava_Wall_4"),

			new NewWall(WallID.Sandstone, "Sandstone", "Sandstone Wall (Unsafe)", "Sandstone_Wall"),
			new NewWall(WallID.HardenedSand, "HardenedSand", "Hardened Sand Wall (Unsafe)", "Hardened_Sand_Wall"),
			new NewWall(WallID.CorruptHardenedSand, "CorruptHardenedSand", "Hardened Ebonsand Wall (Unsafe)", "Hardened_Ebonsand_Wall"),
			new NewWall(WallID.CrimsonHardenedSand, "CrimsonHardenedSand", "Hardened Crimsand Wall (Unsafe)", "Hardened_Crimsand_Wall"),
			new NewWall(WallID.HallowHardenedSand, "HallowHardenedSand", "Hardened Pearlsand Wall (Unsafe)", "Hardened_Pearlsand_Wall"),
			new NewWall(WallID.CorruptSandstone, "CorruptSandstone", "Ebonsandstone Wall (Unsafe)", "Ebonsandstone_Wall"),
			new NewWall(WallID.CrimsonSandstone, "CrimsonSandstone", "Crimsandstone Wall (Unsafe)", "Crimsandstone_Wall"),
			new NewWall(WallID.HallowSandstone, "HallowSandstone", "Pearlsandstone Wall (Unsafe)", "Pearlsandstone_Wall"),
			new NewWall(WallID.DesertFossil, "DesertFossil", "Desert Fossil Wall (Unsafe)", "Desert_Fossil_Wall"),

			new NewWall(WallID.MushroomUnsafe, "MushroomUnsafe", "Mushroom Wall (Unsafe)", "Mushroom_Wall"),
			new NewWall(WallID.HellstoneBrickUnsafe, "HellstoneBrickUnsafe", "Hellstone Brick Wall (Unsafe)", "Hellstone_Brick_Wall"),
			// No longer need clentaminator
			new NewWall(WallID.CrimstoneUnsafe,"CrimstoneUnsafe", "Crimstone Wall (Unsafe)", "Crimstone_Wall"),
			new NewWall(WallID.EbonstoneUnsafe,"EbonstoneUnsafe", "Ebonstone Wall (Unsafe)", "Ebonstone_Wall"),
			new NewWall(WallID.PearlstoneBrickUnsafe,"PearlstoneBrickUnsafe", "Pearlstone Wall (Unsafe)", "Pearlstone_Wall"),

			new NewWall(WallID.CorruptGrassUnsafe,"CorruptGrassUnsafe", "Corrupt Grass Wall (Unsafe)", "Corrupt_Grass_Wall"),
			new NewWall(WallID.CrimsonGrassUnsafe,"CrimsonGrassUnsafe", "Crimson Grass Wall (Unsafe)", "Crimson_Grass_Wall"),
			new NewWall(WallID.HallowedGrassUnsafe,"HallowedGrassUnsafe", "Hallowed Grass Wall (Unsafe)", "Hallowed_Grass_Wall"),

			new NewWall(WallID.MarbleUnsafe,"MarbleUnsafe", "Marble Wall (Unsafe)", "Marble_Wall"),
			new NewWall(WallID.GraniteUnsafe,"GraniteUnsafe", "Granite Wall (Unsafe)", "Granite_Wall"),

			//new NewWall(WallID., ""),
		};

		NewWall[] convertOnlyWalls = new NewWall[] {
			new NewWall(WallID.HiveUnsafe,"HiveUnsafe", "Hive Wall (Unsafe)", "Hive_Wall"),
	//		new NewWall(WallID.MarbleUnsafe,"MarbleUnsafe", "Marble Wall (Unsafe)", "Marble_Wall"),
	//		new NewWall(WallID.GraniteUnsafe,"GraniteUnsafe", "Granite Wall (Unsafe)", "Granite_Wall"),
			new NewWall(WallID.GrassUnsafe,"GrassUnsafe", "Grass Wall (Unsafe)", "Grass_Wall"),
			new NewWall(WallID.FlowerUnsafe,"FlowerUnsafe", "Flower Wall (Unsafe)", "Flower_Wall"),
			new NewWall(WallID.LihzahrdBrickUnsafe,"LihzahrdBrickUnsafe", "Lihzahrd Brick Wall (Unsafe)", "Lihzahrd_Brick_Wall"),

			new NewWall(WallID.BlueDungeonUnsafe,"BlueDungeonUnsafe", "Blue Dungeon Brick Wall (Unsafe)", "Blue_Brick_Wall"),
			new NewWall(WallID.BlueDungeonSlabUnsafe,"BlueDungeonSlabUnsafe", "Blue Dungeon Slab Wall (Unsafe)", "Blue_Slab_Wall"),
			new NewWall(WallID.BlueDungeonTileUnsafe,"BlueDungeonTileUnsafe", "Blue Dungeon Tile Wall (Unsafe)", "Blue_Tiled_Wall"),
			new NewWall(WallID.PinkDungeonUnsafe,"PinkDungeonUnsafe", "Pink Dungeon Brick Wall (Unsafe)", "Pink_Brick_Wall"),
			new NewWall(WallID.PinkDungeonSlabUnsafe,"PinkDungeonSlabUnsafe", "Pink Dungeon Slab Wall (Unsafe)", "Pink_Slab_Wall"),
			new NewWall(WallID.PinkDungeonTileUnsafe,"PinkDungeonTileUnsafe", "Pink Dungeon Tile Wall (Unsafe)", "Pink_Tiled_Wall"),
			new NewWall(WallID.GreenDungeonUnsafe,"GreenDungeonUnsafe", "Green Dungeon Brick Wall (Unsafe)", "Green_Brick_Wall"),
			new NewWall(WallID.GreenDungeonSlabUnsafe,"GreenDungeonSlabUnsafe", "Green Dungeon Slab Wall (Unsafe)", "Green_Slab_Wall"),
			new NewWall(WallID.GreenDungeonTileUnsafe,"GreenDungeonTileUnsafe", "Green Dungeon Tile Wall (Unsafe)", "Green_Tiled_Wall"),

			new NewWall(WallID.ObsidianBrickUnsafe,"ObsidianBrickUnsafe", "Obsidian Brick Wall (Unsafe)", "Obsidian_Brick_Wall"),  //WallID.ObsidianBrick// drops the other naturally
			//new NewWall(WallID., ""),
		};

		// Just for recipes.
		// Original item, original 
		
			//new ConvertWall(ItemID.PearlstoneBrickWall, WallID.PearlstoneBrickUnsafe),
			//new ConvertWall(ItemID.EbonstoneBrickWall, WallID.EbonstoneBrick, WallID.EbonstoneUnsafe),
		ConvertWall[] convertToUnsafeWalls = new ConvertWall[] {
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

			// No harvest since harvest drops safe
			new ConvertWall(ItemID.HiveWall, WallID.HiveUnsafe), // TODO
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



			
			// 
			//new ConvertWall(ItemID., WallID.Jungle, WallID.HallowedGrassUnsafe),
			//new ConvertWall(ItemID., WallID., WallID.),
		};

		internal IDictionary<int, int> mapOriginalWallToItemID;
		internal IDictionary<int, int> mapPlaceWallToItemID;

		public AllTheWallsMod()
		{
			Properties = new ModProperties()
			{
				// this automatically gets false for the autoload values
			};
		}

		// Global needs Original Wall to new item
		// Recipes need ?? to new item

		public override void Load()
		{
			mapOriginalWallToItemID = new Dictionary<int, int>();
			mapPlaceWallToItemID = new Dictionary<int, int>();

			// These walls don't drop anything in Vanilla, they should now drop an item that places the unsafe. 
			foreach (var newWall in harvestWalls)
			{
				AllTheWallsItems item = new  AllTheWallsItems(newWall.wallID, newWall.displayName, "AllTheWalls/ItemImages/" + newWall.textureName);
				AddItem(newWall.itemName, item);
				mapOriginalWallToItemID.Add(newWall.wallID, item.item.type);
				mapPlaceWallToItemID.Add(newWall.wallID, item.item.type);
			}

			// These walls should harvest the safe in Vanilla, but a recipe will allow for obtaining unsafe: hive, dungeon, etc
			foreach (var newWall in convertOnlyWalls)
			{
				AllTheWallsItems item = new AllTheWallsItems(newWall.wallID, newWall.displayName, "AllTheWalls/ItemImages/" + newWall.textureName);
				AddItem(newWall.itemName, item);

				mapPlaceWallToItemID.Add(newWall.wallID, item.item.type);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe;
			foreach (var item in convertToUnsafeWalls)
			{
				recipe = new ModRecipe(this);
				recipe.AddIngredient(item.originalWallItemID, 20);
				recipe.SetResult(mapPlaceWallToItemID[item.newWallID], 20);
				recipe.AddRecipe();

				recipe = new ModRecipe(this);
				recipe.AddIngredient(mapPlaceWallToItemID[item.newWallID], 20);
				recipe.SetResult(item.originalWallItemID, 20);
				recipe.AddRecipe();
			}
		}



		/*
  To Think About:
	Wall to place
	drops from walls that originally drop other walls? (unsafe vs safe)
	Name, display name.

 */


		//private void AddUnobtainableWall(int key, string value)
		//{
		//	mapping.Add(key, value);

		//	AddItem(value, new UnobtainableWallsItems(), "UnobtainableWalls/ItemImages/" + value);
		//}

		//mapping = new Dictionary<int, string>();
		//AddUnobtainableWall(WallID.SnowWallUnsafe, "SnowWallUnsafe");

		//AddUnobtainableWall(WallID.MudUnsafe, "MudUnsafe");

		//AddUnobtainableWall(WallID.AmethystUnsafe, "Amethyst_Wall");
		//AddUnobtainableWall(WallID.EmeraldUnsafe, "Emerald_Wall");
		//AddUnobtainableWall(WallID.TopazUnsafe, "Topaz_Wall");
		//AddUnobtainableWall(WallID.SapphireUnsafe, "Sapphire_Wall");
		//AddUnobtainableWall(WallID.DiamondUnsafe, "DiamondUnsafe");

		//AddUnobtainableWall(WallID.HallowUnsafe1, "Hallow_Wall_1");
		//AddUnobtainableWall(WallID.HallowUnsafe2, "Hallow_Wall_2");
		//AddUnobtainableWall(WallID.HallowUnsafe3, "Hallow_Wall_3");
		//AddUnobtainableWall(WallID.HallowUnsafe4, "Hallow_Wall_4");
		//((CheatSheetModInterface)cheatSheet).RegisterButton(this.buttonPressed);
		//((CheatSheetModInterface)cheatSheet).RegisterButton(this.buttonPressed2);
		//cheatSheet.Call("AddButton_Test", this.GetTexture("ItemImages/Hallow_Wall_1"), (Action)this.buttonPressed2, (Func<string>)this.buttonTooltip2);

		// Add your button by checking if CheatSheet is loaded in PostSetupContent
		//public override void PostSetupContent()
		//{
		//	Mod cheatSheet = ModLoader.GetMod("CheatSheet");
		//	if(cheatSheet != null && !Main.dedServ)
		//	{
		//		cheatSheet.Call("AddButton_Test", this.GetTexture("ItemImages/SnowWallUnsafe"), (Action)this.AdvanceTimeButtonPressed, (Func<string>)this.AdvanceTimeButtonTooltip);
		//	}
		//}

		//// This method is called when the cursor is hovering over the button
		//private string AdvanceTimeButtonTooltip()
		//{
		//	if (Main.dayTime)
		//	{
		//		if (Main.time > 27000.0)
		//		{
		//			return "Advance to 7:30 PM (Dusk)";
		//		}
		//		else
		//		{
		//			return "Advance to Noon";
		//		}
		//	}
		//	else
		//	{
		//		if (Main.time > 16200.0)
		//		{
		//			return "Advance to 4:30 AM (Dawn)";
		//		}
		//		else
		//		{
		//			return "Advance to Midnight";
		//		}
		//	}
		//}

		//// This method is called when the button is pressed.
		//public void AdvanceTimeButtonPressed()
		//{
		//	if (Main.dayTime)
		//	{
		//		if (Main.time > 27000.0)
		//		{
		//			Main.dayTime = false;
		//			Main.time = 0.0;
		//		}
		//		else
		//		{
		//			Main.dayTime = true;
		//			Main.time = 27000.0;
		//		}
		//	}
		//	else
		//	{
		//		if (Main.time > 16200.0)
		//		{
		//			Main.dayTime = true;
		//			Main.time = 0.0;
		//		}
		//		else
		//		{
		//			Main.dayTime = false;
		//			Main.time = 16200.0;
		//		}
		//	}
		//}

		//public void buttonPressed2()
		//{
		//}

		//public string buttonTooltip2()
		//{
		//	return "?";
		//}

		//ConvertWall[] convertToUnsafeWalls = new ConvertWall[] {
		//	new ConvertWall(ItemID.DirtWall, WallID.Dirt, WallID.DirtUnsafe),
		//	new ConvertWall(ItemID.DirtWall, WallID.Dirt, WallID.DirtUnsafe1),
		//	new ConvertWall(ItemID.DirtWall, WallID.Dirt, WallID.DirtUnsafe2),
		//	new ConvertWall(ItemID.DirtWall, WallID.Dirt, WallID.DirtUnsafe3),
		//	new ConvertWall(ItemID.DirtWall, WallID.Dirt, WallID.DirtUnsafe4),
		//	new ConvertWall(ItemID.BlueBrickWall, WallID.BlueDungeon, WallID.BlueDungeonUnsafe),
		//	new ConvertWall(ItemID.GreenBrickWall, WallID.GreenDungeon, WallID.GreenDungeonUnsafe),
		//	new ConvertWall(ItemID.PinkBrickWall, WallID.PinkDungeon, WallID.PinkDungeonUnsafe),
		//	new ConvertWall(ItemID.PearlstoneBrickWall, WallID.PearlstoneBrick, WallID.PearlstoneBrickUnsafe),
		//	//new ConvertWall(ItemID.EbonstoneBrickWall, WallID.EbonstoneBrick, WallID.EbonstoneUnsafe),
		//	new ConvertWall(ItemID.GrassWall, WallID.Grass, WallID.GrassUnsafe),
		//	new ConvertWall(ItemID.JungleWall, WallID.Jungle, WallID.JungleUnsafe),
		//	new ConvertWall(ItemID.JungleWall, WallID.Jungle, WallID.JungleUnsafe1),
		//	new ConvertWall(ItemID.JungleWall, WallID.Jungle, WallID.JungleUnsafe2),
		//	new ConvertWall(ItemID.JungleWall, WallID.Jungle, WallID.JungleUnsafe3),
		//	new ConvertWall(ItemID.JungleWall, WallID.Jungle, WallID.JungleUnsafe4),
		//	new ConvertWall(ItemID.FlowerWall, WallID.Flower, WallID.FlowerUnsafe),
		//	new ConvertWall(ItemID.MushroomWall, WallID.Mushroom, WallID.MushroomUnsafe),
		//	new ConvertWall(ItemID.BlueSlabWall, WallID.BlueDungeonSlab, WallID.BlueDungeonSlabUnsafe),
		//	new ConvertWall(ItemID.BlueTiledWall, WallID.BlueDungeonTile, WallID.BlueDungeonTileUnsafe),
		//	new ConvertWall(ItemID.PinkSlabWall, WallID.PinkDungeonSlab, WallID.PinkDungeonSlabUnsafe),
		//	new ConvertWall(ItemID.PinkTiledWall, WallID.PinkDungeonTile, WallID.PinkDungeonTileUnsafe),
		//	new ConvertWall(ItemID.GreenSlabWall, WallID.GreenDungeonSlab, WallID.GreenDungeonSlabUnsafe),
		//	new ConvertWall(ItemID.GreenTiledWall, WallID.GreenDungeonTile, WallID.GreenDungeonTileUnsafe),
		//	new ConvertWall(ItemID.HiveWall, WallID.Hive, WallID.HiveUnsafe),
		//	new ConvertWall(ItemID.LihzahrdBrickWall, WallID.LihzahrdBrick, WallID.LihzahrdBrickUnsafe),
		//	new ConvertWall(ItemID.HellstoneBrickWall, WallID.HellstoneBrick, WallID.HellstoneBrickUnsafe),
		//	new ConvertWall(ItemID.MarbleWall, WallID.Marble, WallID.MarbleUnsafe),
		//	new ConvertWall(ItemID.GraniteWall, WallID.Granite, WallID.GraniteUnsafe),
		//	new ConvertWall(ItemID.GrassWall, WallID.Grass, WallID.CorruptGrassUnsafe),
		//	new ConvertWall(ItemID.FlowerWall, WallID.Flower, WallID.CorruptGrassUnsafe),
		//	new ConvertWall(ItemID.JungleWall, WallID.Jungle, WallID.CorruptGrassUnsafe),
		//	new ConvertWall(ItemID.GrassWall, WallID.Grass, WallID.CrimsonGrassUnsafe),
		//	new ConvertWall(ItemID.FlowerWall, WallID.Flower, WallID.CrimsonGrassUnsafe),
		//	new ConvertWall(ItemID.JungleWall, WallID.Jungle, WallID.CrimsonGrassUnsafe),
		//	new ConvertWall(ItemID.GrassWall, WallID.Grass, WallID.HallowedGrassUnsafe),
		//	new ConvertWall(ItemID.FlowerWall, WallID.Flower, WallID.HallowedGrassUnsafe),
		//	new ConvertWall(ItemID.JungleWall, WallID.Jungle, WallID.HallowedGrassUnsafe),

		//	// 
		//	//new ConvertWall(ItemID., WallID.Jungle, WallID.HallowedGrassUnsafe),
		//	//new ConvertWall(ItemID., WallID., WallID.),
		//};
	}
}
