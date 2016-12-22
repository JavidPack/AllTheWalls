using Terraria.ModLoader;
using Terraria.ID;

namespace AllTheWalls
{
	class AllTheWallsItems : ModItem
	{
		// We need this so the call to Activator.CreateInstance in ModLoader.AutoloadItem won't complain
		public AllTheWallsItems() { }

		private string displayName;
		private int wallID;

		public AllTheWallsItems(int wallID, string displayName)
		{
			this.wallID = wallID;
			this.displayName = displayName;
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.StoneWall);
			item.createWall = wallID;
			item.name = displayName;
		}
	}
}