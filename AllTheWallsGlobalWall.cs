using Terraria.ModLoader;

namespace AllTheWalls
{
	class AllTheWallsGlobalWall : GlobalWall
	{
		public override bool Drop(int i, int j, int type, ref int dropType) {
			AllTheWallsMod allTheWallsMod = ModContent.GetInstance<AllTheWallsMod>();
			if (allTheWallsMod.mapOriginalWallToItemID.ContainsKey(type)) {
				dropType = allTheWallsMod.mapOriginalWallToItemID[type];
			}
			return true;
		}
	}
}
