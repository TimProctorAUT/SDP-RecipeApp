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
                new Recipe { Id = Guid.NewGuid().ToString(), Text = "Recipe One", Description="This is an recipe description." },
                new Recipe { Id = Guid.NewGuid().ToString(), Text = "Recipe Two", Description="This is an recipe description." },
                new Recipe { Id = Guid.NewGuid().ToString(), Text = "Recipe Three", Description="This is an recipe description." },
                new Recipe { Id = Guid.NewGuid().ToString(), Text = "Recipe Four", Description="This is an recipe description." },
                new Recipe { Id = Guid.NewGuid().ToString(), Text = "Recipe Five", Description="This is an recipe description." },
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