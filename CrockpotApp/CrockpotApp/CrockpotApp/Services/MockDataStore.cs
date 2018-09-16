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
                                ImageURL = "nachos.png",
                                PrepTime = 10,
                                CookTime = 25,
                                TotalSteps = 3,
                                RecipeSteps = new List<RecipeStep>
                               {
                                   new RecipeStep
                                   {
                                       PageID = 1,
                                       Title = "Step 1",
                                       InstructionText = "Heat a dash of oil in a frying pan and over " +
                                                            "a high heat brown mince. This may be best done in 2 batches.",
                                       TotalPages = 3
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 2,
                                       Title = "Step 2",
                                       InstructionText = "Reduce heat. Pour over Salsa and add Kidney Beans. Stir and simmer " +
                                                                    "for 15-20 minutes, until the mince is cooked.",
                                       TotalPages = 3
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 3,
                                       Title = "Step 3",
                                       InstructionText = "Place corn chips in an oven proof dish. Spoon over the nacho mix. " +
                                                                "Scatter over grated cheese. Place under a preheated grill, " +
                                                                        "and grill for 3-4 minutes until the cheese is melted.",
                                       TotalPages = 3
                                   },
                               },
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
                               ImageURL = "corn_fritters.png",
                               PrepTime = 5,
                               CookTime = 5,
                               TotalSteps = 3,
                               RecipeSteps = new List<RecipeStep>
                               {
                                   new RecipeStep
                                   {
                                       PageID = 1,
                                       Title = "Step 1",
                                       InstructionText = "Sift flour, baking powder and salt into a mixing bowl.",
                                       TotalPages = 3
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 2,
                                       Title = "Step 2",
                                       InstructionText = "Add beaten egg and Cream Style Corn and mix well." +
                                                                             " Fold in Whole Kernel Corn",
                                       TotalPages = 3
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 3,
                                       Title = "Step 3",
                                       InstructionText = "Heat 1 – 2 tablespoons of oil in a non stick frying pan. " +
                                                                        "Place spoonfuls of the corn fritter mixture into the pan. " +
                                                                        "Cook over a medium heat for 2-3 minutes until bubbles appear on the surface" +
                                                                        " of the batter. Turn and cook the other side for a further 2-3 minutes " +
                                                                        "until fritters are golden and cooked through. It maybe necessary to " +
                                                                        "add extra oil to the pan during cooking.",
                                       TotalPages = 3
                                   },
                               },
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
                               ImageURL = "potato_pea_samosa.jpg",
                               PrepTime = 30,
                               CookTime = 20,
                               TotalSteps = 6,
                               RecipeSteps = new List<RecipeStep>
                               {
                                   new RecipeStep
                                   {
                                       PageID = 1,
                                       Title = "Step 1",
                                       InstructionText = "Cook potatoes in boiling lightly salted water until tender. Drain and set aside.",
                                       TotalPages = 6
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 2,
                                       Title = "Step 2",
                                       InstructionText = "Heat a dash of oil in a small saucepan. Add onion and garlic and cook over a" +
                                                                " medium to low heat until onion is soft. Add ground coriander, cumin seeds and " +
                                                                        "turmeric, adding an extra dash of oil if the pan is dry",
                                       TotalPages = 6
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 3,
                                       Title = "Step 3",
                                       InstructionText = "Add chilli, lime juice and Frozen Peas. " +
                                                                "Cover and cook for 5 minutes until the peas are tender, stirring regularly.",
                                       TotalPages = 6
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 4,
                                       Title = "Step 4",
                                       InstructionText = "Mix cooked diced potato, pea mixture and chopped coriander together. " +
                                                                "Season with salt and pepper to taste. Set aside to cool. Preheat oven to 200°C (fan bake).",
                                       TotalPages = 6
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 5,
                                       Title = "Step 5",
                                       InstructionText = "Cut each pastry sheet into 4. Place a spoonful of filling in the middle of each square. " +
                                                                    "Wet the edges of the pastry and fold over to make a triangle. Seal edges with a fork.",
                                       TotalPages = 6
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 6,
                                       Title = "Step 6",
                                       InstructionText = "Place samosas on an oven tray lined with baking paper. Brush with a little beaten egg or milk. " +
                                                                    "Bake for 15-20 minutes until the pastry is golden and filling hot.",
                                       TotalPages = 6
                                   },
                               },
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
                               ImageURL = "shepherds_pie.jpg",
                               PrepTime = 20,
                               CookTime = 10,
                               TotalSteps = 5,
                               RecipeSteps = new List<RecipeStep>
                               {
                                   new RecipeStep
                                   {
                                       PageID = 1,
                                       Title = "Step 1",
                                       InstructionText = "Preheat oven to 180°C.",
                                       TotalPages = 5
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 2,
                                       Title = "Step 2",
                                       InstructionText = "Cook potatoes in a saucepan of boiling water, drain, season with salt and pepper" +
                                                                    " and mash. When cooled slightly, quickly whip through the beaten egg",
                                       TotalPages = 5
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 3,
                                       Title = "Step 3",
                                       InstructionText = "Heat a dash of oil in a frying plan and brown the minced meat and bacon, then add the onion and continue" +
                                                                    " cooking for a further 2 minutes. Add tomato sauce, Worcestershire sauce and mustard." +
                                                                    " Dissolve yeast extract, marmite or vegemite in ½ cup boiling water. Add it to the mince " +
                                                                    "with the Frozen Mixed Vegetables and cook for a further 2 minutes " +
                                                                    "before placing in an ovenproof dish",
                                       TotalPages = 5
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 4,
                                       Title = "Step 4",
                                       InstructionText = "Top with mashed potatoes and sprinkle with cheese (if using).",
                                       TotalPages = 5
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 5,
                                       Title = "Step 5",
                                       InstructionText = "Baked in the preheated oven for about 20 minutes or until the " +
                                                                    "pie has heated through and the cheese has melted.",
                                       TotalPages = 5
                                   },
                               },
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
                               ImageURL = "placeholder.png",
                               PrepTime = 20,
                               CookTime = 10,
                               TotalSteps = 3,
                               RecipeSteps = new List<RecipeStep>
                               {
                                   new RecipeStep
                                   {
                                       PageID = 1,
                                       Title = "Step 1",
                                       InstructionText = "Instruction One Text Following the Cooking Instructions given to the customer to " +
                                                                                "understand how to cook or prepare the food at the current stage.",
                                       TotalPages = 3
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 2,
                                       Title = "Step 2",
                                       InstructionText = "Instruction One Text Following the Cooking Instructions given to the customer to " +
                                                                                "understand how to cook or prepare the food at the current stage.",
                                       TotalPages = 3
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 3,
                                       Title = "Step 3",
                                       InstructionText = "Instruction One Text Following the Cooking Instructions given to the customer to " +
                                                                                "understand how to cook or prepare the food at the current stage.",
                                       TotalPages = 3
                                   },
                               },
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
                               ImageURL = "placeholder.png",
                               PrepTime = 20,
                               CookTime = 10,
                               TotalSteps = 3,
                               RecipeSteps = new List<RecipeStep>
                               {
                                   new RecipeStep
                                   {
                                       PageID = 1,
                                       Title = "Step 1",
                                       InstructionText = "Instruction One Text Following the Cooking Instructions given to the customer to " +
                                                                                "understand how to cook or prepare the food at the current stage.",
                                       TotalPages = 3
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 2,
                                       Title = "Step 2",
                                       InstructionText = "Instruction One Text Following the Cooking Instructions given to the customer to " +
                                                                                "understand how to cook or prepare the food at the current stage.",
                                       TotalPages = 3
                                   },

                                   new RecipeStep
                                   {
                                       PageID = 3,
                                       Title = "Step 3",
                                       InstructionText = "Instruction One Text Following the Cooking Instructions given to the customer to " +
                                                                                "understand how to cook or prepare the food at the current stage.",
                                       TotalPages = 3
                                   },
                               },
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