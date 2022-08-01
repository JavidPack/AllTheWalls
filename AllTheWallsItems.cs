using Terraria.ID;
using Terraria.ModLoader;

namespace AllTheWalls
{
	[Autoload(false)]
	class AllTheWallsItems : ModItem
	{
		private int wallID;
		private string name;
		private string displayName;
		private string texturePath;

		protected override bool CloneNewInstances => true;
		public override string Texture => texturePath;

		public override string Name => name;

		public AllTheWallsItems(string name, int wallID, string displayName, string texturePath) {
			this.name = name;
			this.wallID = wallID;
			this.displayName = displayName;
			this.texturePath = texturePath;
		}

		public override void SetStaticDefaults() {
			DisplayName.SetDefault(displayName);
		}

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.StoneWall);
			Item.createWall = wallID;
		}
	}
}