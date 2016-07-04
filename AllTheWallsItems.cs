using Terraria.ModLoader;
using Terraria.ID;

namespace AllTheWalls
{
	class AllTheWallsItems : ModItem
	{
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.StoneWall);
			item.createWall = ((AllTheWallsMod)mod).mapItemIDToPlaceWall[item.type];
			item.name = ((AllTheWallsMod)mod).mapItemIDToDisplayName[item.type];
		}
	}
}