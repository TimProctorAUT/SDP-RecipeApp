using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CrockpotApp.ViewModels;
using CrockpotApp.Models;
using CrockpotApp.Views;

namespace CrockpotApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeStepPage : ContentPage
	{
        RecipeStepViewModel viewModel;
        public int CurrentPageNumber { get; set; }
        public int TotalPageCount { get; set; }
        Recipe Item { get; set; }

		public RecipeStepPage ()
		{
            CurrentPageNumber = 0;
            TotalPageCount = 0;

            InitializeComponent ();
            
            BindingContext = viewModel = new RecipeStepViewModel(CurrentPageNumber, TotalPageCount, null);
        }

        public RecipeStepPage (Recipe item, int PageNumber, int TotalPages)
        {
            InitializeComponent();

            CurrentPageNumber = PageNumber;
            TotalPageCount = TotalPages;
            Item = item;

            InstructionText.Text = Item.RecipeSteps[CurrentPageNumber-1].InstructionText;
            StepTitle.Text = Item.RecipeSteps[CurrentPageNumber - 1].Title;
            
            BindingContext = viewModel = new RecipeStepViewModel(CurrentPageNumber, TotalPageCount, Item);
                        
            MainImage.Source = ImageSource.FromFile(Item.ImageURL);

            if (CurrentPageNumber == TotalPageCount)
            {
                NextStep.Text = "Finish";
            }
        }
        async void NextStep_Clicked(object sender, EventArgs e)
        {

            if (CurrentPageNumber < TotalPageCount)
            {
                    await Navigation.PushModalAsync(new NavigationPage(new RecipeStepPage(Item, CurrentPageNumber + 1, TotalPageCount)));
             
            }
            
            if (NextStep.Text.Equals("Finish"))
            {
                for (int pop = 0; pop < TotalPageCount - 1; pop++)
                {
                    Navigation.PopModalAsync(); //'await' not used to allow for multiple Pops before to be called at once
                }

                await Navigation.PopModalAsync();
            }
           
        }

        async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}