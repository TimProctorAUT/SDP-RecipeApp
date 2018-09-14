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
                                Text = "Simple Beef Nachos",
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
                               Text = "Corn Fritters",
                               Summary = "Create some Delicious Corn Fritters in under 15 minutes",
                               Description ="Make 10 Fluffy and delicious Corn Fritters in under 15 minutes",
                               PrepTime = 5,
                               CookTime = 5,
                               RecipeSteps = new List<string>{"StageOne", "StageTwo", "StageThree"},
                               IngredientList = new List<Ingredient>
                               {
                                   new Ingredient
                                   {
                                       Name = "Flour",
                                       Quantity = "1/2 Cup"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Baking Powder",
                                       Quantity = "1 tsp"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Salt",
                                       Quantity = "1/2 tsp"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Egg",
                                       Quantity = "2"

                                   },

                                   new Ingredient
                                   {
                                       Name = "Cream Style Corn",
                                       Quantity = "410g"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Whole Kernel Corn",
                                       Quantity = "410g"
                                   }
                               }
                            },

                new Recipe {   Id = Guid.NewGuid().ToString(),
                               Text = "Curried Pea & Potato Samosas",
                               Summary = "Cook some crunchy samosas with in 50 minutes",
                               Description ="Make 12 curried pea and potato samosas in 50 minutes",
                               PrepTime = 30,
                               CookTime = 20,
                               RecipeSteps = new List<string>{"StageOne", "StageTwo", "StageThree"},
                               IngredientList = new List<Ingredient>
                               {
                                   new Ingredient
                                   {
                                       Name = "Potatoes",
                                       Quantity = "400g"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Small Onion",
                                       Quantity = "1"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Garlic Clove",
                                       Quantity = "2"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Ground Coriander",
                                       Quantity = "2 tsp"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Cumin Seeds",
                                       Quantity = "2 tsp"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Tumeric",
                                       Quantity = "1 tsp"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Red Chilli",
                                       Quantity = "1/2"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Juice of 1 Lime",
                                       Quantity = ""
                                   },

                                   new Ingredient
                                   {
                                       Name = "Frozen Peas",
                                       Quantity = "1 cup"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Flaky Pastry",
                                       Quantity = "3 sheets"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Egg",
                                       Quantity = "1"
                                   }
                               }
                            },

                new Recipe {   Id = Guid.NewGuid().ToString(),
                               Text = "Shepherd's Pie",
                               Summary = "Cook a Kiwi Classic in around 30 minutes",
                               Description ="Cook a Potato topped shepherds pie which can feed 4 to 6 people in 30 minutes",
                               PrepTime = 20,
                               CookTime = 10,
                               RecipeSteps = new List<string>{"StageOne", "StageTwo", "StageThree"},
                               IngredientList = new List<Ingredient>
                               {
                                   new Ingredient
                                   {
                                       Name = "Potatoes",
                                       Quantity = "4 Large"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Egg",
                                       Quantity = "1"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Lamb or Beef Mince",
                                       Quantity = "500g"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Bacon",
                                       Quantity = "2 Rashers"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Onion",
                                       Quantity = "1"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Tomato Sauce",
                                       Quantity = "3 Tbsp"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Worcestershire Sauce",
                                       Quantity = "1 Tbsp"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Mustard",
                                       Quantity = "1 tsp"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Yeast Extract",
                                       Quantity = "1/2 tsp"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Fozen Mixed Vegetables",
                                       Quantity = "1-2 Cups"
                                   },

                                   new Ingredient
                                   {
                                       Name = "Grated Cheese",
                                       Quantity = "1/2 Cup"
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