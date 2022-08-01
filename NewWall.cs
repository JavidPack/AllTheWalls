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
		}
	}
}
