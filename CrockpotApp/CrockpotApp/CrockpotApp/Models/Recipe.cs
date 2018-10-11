  using System;
using System.Collections.Generic;

namespace CrockpotApp.Models
{
    /// <summary>
    /// Recipe.cs - Class Defining the Recipe Object
    /// </summary>
    /// 
    /// <remarks>
    ///Variables:
    ///1)  Id               - String value given as an randomly generated string of text.
    ///2)  Text             - String value defining the Title of the recipe
    ///3)  Description      - String value holding the Descrption shown on the detailed recipe page
    ///4)  Summary          - String value holding the summaried description of the recipe to be displayed on the recipe list on the main page
    ///5)  ImageURL         - String value holding the file name of the main image of the selected recipe.
    ///6)  IngredientList   - A Collections List of Ingredient Objects holding all Ingredients of the current recipe
    ///7)  RecipeSteps      - A Collections List of RecipeStep Objects holding all Steps of the current recipes
    ///8)  PrepTime         - Integer value defining the time taken to prepare the meal
    ///9)  CookTime         - Integer value defining the time taken to cook the meal
    ///10) TotalSteps       - Integer value defining the total number of pages and steps in the recipe.
    ///11) mealType         - String value defining the Category that the meal should be stored in
    /// </remarks>
    public class Recipe
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public string ImageURL { get; set; }
        public List<Ingredient> IngredientList { get; set; }
        public List<RecipeStep> RecipeSteps { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public int TotalSteps { get; set; }
        public string mealType { get; set; }
    }
}