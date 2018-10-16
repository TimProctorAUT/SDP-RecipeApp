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
    /// <summary>
    /// RecipeStepViewModel.cs - A Class Defining the GUI and Linking Services to the A Page Where it is Called 
    /// </summary>
    /// 
    ///<remarks>
    ///Variable:
    ///
    /// 1) Item                                         -
    /// 2) RecipeSteps                                  -
    /// 3) LoadRecipeStepCommand                        -
    /// </remarks>
    /// 
    ///<remarks>
    ///Methods and Constructors:
    ///
    /// 1) RecipeStepViewModel(Recipe)                  - 
    /// 2) RecipeStepViewModel(int, int, Recipe)        -
    /// 3) ExecuteLoadRecipeCommand()                   -
    /// </remarks>
    public class RecipeStepViewModel : BaseViewModel
    {
        public Recipe Item { get; set; }
        public ObservableCollection<RecipeStep> RecipeSteps { get; set; }
        public Command LoadRecipeStepCommand { get; set; }

        /// <summary>
        /// Default RecipeStepViewModel Constructor
        /// </summary>
        ///  
        /// <param name="item"></param>
        /// 
        /// <remarks>
        /// This Constructor takes in the a Recipe Object (Item) and Sets it == null if nothing is given
        /// 
        /// Title is a String Value Which is used in the XAML On the Main Toolbar.
        /// </remarks>
        public RecipeStepViewModel(Recipe item = null)
        {
            Title = (item?.Text);
            Item = item;
            RecipeSteps = new ObservableCollection<RecipeStep>();
            LoadRecipeStepCommand = new Command(async() => await ExecuteLoadRecipeStepCommand());
        }

        /// <summary>
        /// RecipeStepViewModel Constructor
        /// </summary>
        /// 
        /// <param name="PageNumber"></param>
        /// <param name="TotalPage"></param>
        /// <param name="item"></param>
        /// 
        ///<remarks>
        /// This Constructor takes in two integer values which hold the Current Page Number and 
        /// How many pages there are total and a Recipe Object
        /// 
        /// Title, like the default constructor is a String Value which is Used and Declared on the Main Toolbar of the GUI
        ///</remarks>
        public RecipeStepViewModel(int PageNumber, int TotalPage, Recipe item)
        {
            Title = (item?.Text + " - (" + PageNumber + "/" + TotalPage + ")");
            Item = item;
            RecipeSteps = new ObservableCollection<RecipeStep>();
            LoadRecipeStepCommand = new Command(async () => await ExecuteLoadRecipeStepCommand());
        }

        /// <summary>
        /// ExecuteLoadRecipeStepCommand Method
        /// </summary>
        /// 
        /// <remarks>
        /// An async Method which executes a command. In this case creates a List of the RecipeSteps of the current
        /// Recipe Item.
        /// </remarks> 
        /// 
        /// <returns>
        /// Task Object -- Used with Threading
        /// </returns>
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
