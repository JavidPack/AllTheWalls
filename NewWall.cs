using Terraria.ID;

namespace AllTheWalls
{
	class NewWall
	{
		public int wallID; // id of wall that drops this item
		public string displayName; // name displayed to player
		public string itemName; // name for records, don't change between releases
		public string textureName; // texture name

		public NewWall(ushort wallID, string itemName, string displayName, string textureName) {
			this.wallID = wallID;
			this.itemName = itemName;
			this.displayName = displayName;
			this.textureName = textureName;
			if (!textureName.StartsWith("Terraria"))
				this.textureName = "AllTheWalls/ItemImages/" + textureName;
		}

		public NewWall(ushort wallID, string itemName, string displayName, int textureItemID) {
			this.wallID = wallID;
			this.itemName = itemName;
			this.displayName = displayName;
			this.textureName = $"Terraria/Images/Item_{textureItemID}";
		}

		public NewWall(ushort wallID, string itemName, int textureItemID) {
			this.wallID = wallID;
			this.itemName = itemName;
			this.displayName = $"{{$ItemName.{ItemID.Search.GetName(textureItemID)}}} {{$Mods.AllTheWalls.UnsafeInParenthesis}}";
			this.textureName = $"Terraria/Images/Item_{textureItemID}";
		}
	}
}
