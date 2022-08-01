using Terraria.ID;
using Terraria.ModLoader;

namespace AllTheWalls
{
	class AllTheWallsGlobalWall : GlobalWall
	{
		public override bool IsLoadingEnabled(Mod mod)/* tModPorter Suggestion: If you return false for the purposes of manual loading, use the [Autoload(false)] attribute on your class instead */
		{
			return true;
		}

		public override bool Drop(int i, int j, int type, ref int dropType)
		{
			if (((AllTheWallsMod)Mod).mapOriginalWallToItemID.ContainsKey(type))
			{
				dropType = ((AllTheWallsMod)Mod).mapOriginalWallToItemID[type];
			}
			return true;
		}
	}
}
