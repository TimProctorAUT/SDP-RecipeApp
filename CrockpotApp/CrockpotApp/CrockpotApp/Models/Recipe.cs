using System;
using System.Collections.Generic;

namespace CrockpotApp.Models
{
    public class Recipe
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public string Summary { get; set; }
        public List<string> IngredientList { get; set; }
        public List<string> RecipeSteps { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }

    }
}