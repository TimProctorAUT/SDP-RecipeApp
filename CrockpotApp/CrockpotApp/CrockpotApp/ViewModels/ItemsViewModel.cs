﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using CrockpotApp.Models;
using CrockpotApp.Views;

namespace CrockpotApp.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Recipe> Items { get; set; }
        public Command LoadItemsCommand { get; set; }
        public bool RecipeNotFound { get; set; }

        public ItemsViewModel()
        {
            Title = "All Recipes";
            Items = new ObservableCollection<Recipe>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
                        
        }

        public ItemsViewModel(string mealType)
        {
            Title = mealType;
            Items = new ObservableCollection<Recipe>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand(mealType));
                       
        }

        public ItemsViewModel(string ingredient, int ID)
        {
            RecipeNotFound = false;
            Title = "Search for "+ingredient;
            Items = new ObservableCollection<Recipe>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand(ingredient, 1));

        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        async Task ExecuteLoadItemsCommand(string mealType)
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    if (item.mealType == mealType)
                    {
                        Items.Add(item);
                    }                    
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        async Task ExecuteLoadItemsCommand(string ingredient, int ID)
        {
            if (IsBusy)
                return;

            IsBusy = true;
            
            try
            {

                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    foreach (var ingredients in item.IngredientList)
                    {
                        if (ingredients.Name.ToUpper().Contains(ingredient.ToUpper()))
                        {
                            if(!Items.Contains(item))
                            {
                                Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}