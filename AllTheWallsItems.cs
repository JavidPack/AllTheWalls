using Terraria.ModLoader;
using Terraria.ID;

namespace AllTheWalls
{
	class AllTheWallsItems : ModItem
	{
		private int wallID;
		private string displayName;
		private string texturePath;

		public override bool CloneNewInstances => true;
		public override string Texture => texturePath;

		public AllTheWallsItems(int wallID, string displayName, string texturePath)
		{
			this.wallID = wallID;
			this.displayName = displayName;
			this.texturePath = texturePath;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault(displayName);
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.StoneWall);
			item.createWall = wallID;
		}
	}
}