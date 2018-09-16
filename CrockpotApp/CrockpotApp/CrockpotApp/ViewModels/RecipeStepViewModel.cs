using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using CrockpotApp.Models;
using Xamarin.Forms;

namespace CrockpotApp.ViewModels
{
    public class RecipeStepViewModel : BaseViewModel
    {
        public Recipe Item { get; set; }
        public ObservableCollection<RecipeStep> RecipeSteps { get; set; }
        public Command LoadRecipeStepCommand { get; set; }

        public RecipeStepViewModel(Recipe item = null)
        {
            Title = (item?.Text); //ADD PAGE COUNTER AFTER TITLE
            Item = item;
            RecipeSteps = new ObservableCollection<RecipeStep>();
            LoadRecipeStepCommand = new Command(async() => await ExecuteLoadRecipeStepCommand());
        }

        public RecipeStepViewModel(int PageNumber, int TotalPage, Recipe item)
        {
            Title = (item?.Text + " - (" + PageNumber + "/" + TotalPage + ")");
            Item = item;
            RecipeSteps = new ObservableCollection<RecipeStep>();
            LoadRecipeStepCommand = new Command(async () => await ExecuteLoadRecipeStepCommand());
        }

        async Task ExecuteLoadRecipeStepCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                RecipeSteps.Clear();
                var items = await DataStore.GetItemAsync(Item.Id);
                foreach (var recipeStep in items.RecipeSteps)
                {
                    RecipeSteps.Add(recipeStep);
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
