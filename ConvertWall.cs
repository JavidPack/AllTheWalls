namespace AllTheWalls
{
	class ConvertWall
	{
		internal int originalWallItemID;
		internal int newWallID;

		public ConvertWall(short originalWallItemID, ushort newWallID) {
			this.originalWallItemID = originalWallItemID;
			this.newWallID = newWallID;
		}
	}
}
