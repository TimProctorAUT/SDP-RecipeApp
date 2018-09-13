using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrockpotApp.Models;

namespace CrockpotApp.Services
{
    public class MockDataStore : IDataStore<Recipe>
    {
        List<Recipe> items;

        public MockDataStore()
        {
            items = new List<Recipe>();
            var mockItems = new List<Recipe>
            {


                new Recipe {    Id = Guid.NewGuid().ToString(),
                                Text = "Simple Nachos",
                                Summary = "Prepare a Dish of Simple Beef Nachos in Just 35 Minutes",
                                Description ="Prepare a dish of Beef Nachos for 4 people in Just 35 Minutes",
                                PrepTime = 10,
                                CookTime = 25,
                                RecipeSteps = new List<string>{"StageOne", "StageTwo", "StageThree" },
                                IngredientList = new List<Ingredient>
                               {
                                   new Ingredient
                                   {
                                       Name = "Beef Mince",
                                       Quantity = "400g"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Salsa",
                                       Quantity = "525g"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Red Kidney Beans",
                                       Quantity = "400g"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Grated Cheese",
                                       Quantity = "1/2 Cup"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Corn Chips",
                                       Quantity = "1 Packet"
                                   }
                               }
                            },

                new Recipe {   Id = Guid.NewGuid().ToString(),
                               Text = "Recipe Title",
                               Summary = "Shown Under Title",
                               Description ="Insert Recipe Summary which will be defined in the detailed recipe view",
                               PrepTime = 20,
                               CookTime = 10,RecipeSteps = new List<string>{"StageOne", "StageTwo", "StageThree"},
                               IngredientList = new List<Ingredient>
                               {
                                   new Ingredient
                                   {
                                       Name = "IngredientOne",
                                       Quantity = "400g"
                                   },

                                   new Ingredient
                                   {
                                       Name = "IngredientOne",
                                       Quantity = "1/2 Cups"
                                   },

                                   new Ingredient
                                   {
                                       Name = "IngredientThree",
                                       Quantity = "30g"
                                   }
                               }
                            },

                new Recipe {   Id = Guid.NewGuid().ToString(),
                               Text = "Recipe Title",
                               Summary = "Shown Under Title",
                               Description ="Insert Recipe Summary which will be defined in the detailed recipe view",
                               PrepTime = 20,
                               CookTime = 10,
                               RecipeSteps = new List<string>{"StageOne", "StageTwo", "StageThree"},
                               IngredientList = new List<Ingredient>
                               {
                                   new Ingredient
                                   {
                                       Name = "IngredientOne",
                                       Quantity = "400g"
                                   },

                                   new Ingredient
                                   {
                                       Name = "IngredientOne",
                                       Quantity = "1/2 Cups"
                                   },

                                   new Ingredient
                                   {
                                       Name = "IngredientThree",
                                       Quantity = "30g"
                                   }
                               }
                            },

                new Recipe {   Id = Guid.NewGuid().ToString(),
                               Text = "Recipe Title",
                               Summary = "Shown Under Title",
                               Description ="Insert Recipe Summary which will be defined in the detailed recipe view",
                               PrepTime = 20,
                               CookTime = 10,
                               RecipeSteps = new List<string>{"StageOne", "StageTwo", "StageThree"},
                               IngredientList = new List<Ingredient>
                               {
                                   new Ingredient
                                   {
                                       Name = "IngredientOne",
                                       Quantity = "400g"
                                   },

                                   new Ingredient
                                   {
                                       Name = "IngredientOne",
                                       Quantity = "1/2 Cups"
                                   },

                                   new Ingredient
                                   {
                                       Name = "IngredientThree",
                                       Quantity = "30g"
                                   }
                               }
                            }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Recipe item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Recipe item)
        {
            var oldItem = items.Where((Recipe arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Recipe arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Recipe> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Recipe>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}