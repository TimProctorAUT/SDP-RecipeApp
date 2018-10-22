using System;
  
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CrockpotApp.Models;
using CrockpotApp.ViewModels;

namespace CrockpotApp.Views
{
    /// <summary>
    /// ItemDetailPage.cs
    /// </summary>
    /// 
    ///<remarks>
    /// ItemDetailPage Class used to show details about a selected recipe.
    /// </remarks>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        /// <summary>
        /// ItemDetailPage Default Constructor
        /// </summary>
        /// 
        /// <param name="viewModel"></param>
        /// 
        ///<remarks>
        ///Constructor Takes in a Specific Recipe viewModel and applies it to the detials page
        /// </remarks>
        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            MainImage.Source = ImageSource.FromFile(viewModel.Item.ImageURL);

            BindingContext = this.viewModel = viewModel;            
        }
              
        /// <summary>
        /// BeginCooking_Clicked Method
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        /// <remarks>
        /// Requests To Load the First Recipe Step
        /// </remarks>
        async void BeginCooking_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new RecipeStepPage(viewModel.Item, 1, viewModel.Item.TotalSteps)));
        }
    }
}