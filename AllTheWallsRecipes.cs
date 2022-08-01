using Terraria;
using Terraria.ModLoader;

namespace AllTheWalls
{
	class AllTheWallsRecipes : ModSystem
	{
		public override void AddRecipes()
		{
			AllTheWallsMod allTheWallsMod = ModContent.GetInstance<AllTheWallsMod>();
			Recipe recipe;
			foreach (var item in allTheWallsMod.convertToUnsafeWalls) {
				recipe = Recipe.Create(allTheWallsMod.mapPlaceWallToItemID[item.newWallID], 20);
				recipe.AddIngredient(item.originalWallItemID, 20);
				recipe.Register();

				recipe = Recipe.Create(item.originalWallItemID, 20);
				recipe.AddIngredient(allTheWallsMod.mapPlaceWallToItemID[item.newWallID], 20);
				recipe.Register();
			}
		}
	}
}
