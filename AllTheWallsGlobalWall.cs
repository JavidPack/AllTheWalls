using Terraria.ID;
using Terraria.ModLoader;

namespace AllTheWalls
{
	class AllTheWallsGlobalWall : GlobalWall
	{
		public override bool Autoload(ref string name)
		{
			return true;
		}

		public override bool Drop(int i, int j, int type, ref int dropType)
		{
			if (((AllTheWallsMod)mod).mapOriginalWallToItemID.ContainsKey(type))
			{
				dropType = ((AllTheWallsMod)mod).mapOriginalWallToItemID[type];
			}
			return true;
		}
	}
}
