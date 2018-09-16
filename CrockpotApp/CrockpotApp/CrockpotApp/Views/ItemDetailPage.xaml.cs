using System;
  
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CrockpotApp.Models;
using CrockpotApp.ViewModels;

namespace CrockpotApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;            
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Recipe
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        async void BeginCooking_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new RecipeStepPage(viewModel.Item, 1, viewModel.Item.TotalSteps)));
        }
    }
}