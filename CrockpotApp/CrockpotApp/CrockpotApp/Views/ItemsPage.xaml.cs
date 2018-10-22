using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CrockpotApp.Models;
using CrockpotApp.Views;
using CrockpotApp.ViewModels;

namespace CrockpotApp.Views
{
    /// <summary>
    /// ItemsPage.cs
    /// </summary>
    /// 
    ///<remarks>
    ///Class which loads the list of recipes onto the page.
    /// </remarks>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        /// <summary>
        /// ItemsPage Default Constructor
        /// </summary>
        /// 
        ///<remarks>
        ///The Default Contructor which loads all Recipes into the List.
        /// </remarks>
        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ItemsViewModel();
        }

        /// <summary>
        /// ItemsPage Constructor - Categories
        /// </summary>
        /// 
        /// <param name="mealType"></param>
        /// 
        ///<remarks>
        /// The Constructor Called to load a list of recipes from a specific Category.
        /// </remarks>
        public ItemsPage(string mealType)
        {
            InitializeComponent();
            BindingContext = viewModel = new ItemsViewModel(mealType);
        }
        
        /// <summary>
        /// ItemsPage Contructor - Ingredient
        /// </summary>
        /// 
        /// <param name="ingredient"></param>
        /// <param name="ID"></param>
        /// 
        ///<remarks>
        ///The Constructor called to load a list of recipes which contains the Searched Ingredient.
        /// </remarks>
        public ItemsPage(string ingredient, int ID)
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel(ingredient, ID);
        }
            
        /// <summary>
        /// OnItemSelected Method
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// 
        ///<remarks>
        /// Opens a selected Recipes Detailed Page once the recipe is clicked.
        /// </remarks>
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Recipe;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        /// <summary>
        /// AddItem_Clicked Method
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        ///<remarks>
        ///Opens the Search For Item Page which includes Categories and Search by Ingredients.
        /// </remarks>
        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new CategoryPage(viewModel.Items)));
        }

        /// <summary>
        /// OnAppearing Method
        /// </summary>
        /// 
        ///<remarks>
        /// OnAppearing Method needed to be Initialised to run the program. Not Used in the Current Program.
        /// </remarks>
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}