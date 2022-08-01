using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
			SacrificeTotal = 400;
		}

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.StoneWall);
			Item.createWall = wallID;
		}

		public override void PostDrawInInventory(SpriteBatch spriteBatch, Vector2 position, Rectangle frame, Color drawColor, Color itemColor, Vector2 origin, float scale) {
			spriteBatch.Draw(Mod.Assets.Request<Texture2D>("ItemImages/SkullOverlay").Value, position + scale * new Vector2(frame.Width - 14, frame.Height - 14), null, Color.White, 0f, origin, scale, SpriteEffects.None, 0);
			base.PostDrawInInventory(spriteBatch, position, frame, drawColor, itemColor, origin, scale);
		}
	}
}