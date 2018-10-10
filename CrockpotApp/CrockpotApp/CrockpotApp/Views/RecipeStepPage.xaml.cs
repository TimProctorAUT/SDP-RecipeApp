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
using System.Threading;

namespace CrockpotApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipeStepPage : ContentPage
	{
        RecipeStepViewModel viewModel;
        public int CurrentPageNumber { get; set; }
        public int TotalPageCount { get; set; }
        Recipe Item { get; set; }

        CancellationTokenSource cts;

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
            
            //TODO: Move to Own Method, Add Placeholder Image if URL = NULL or Image Doesnt Exist
            MainImage.Source = ImageSource.FromFile(Item.ImageURL);
            
            if (CurrentPageNumber == TotalPageCount)
            {
                NextStep.Text = "Finish";
            }

            //Enable Timer if Applicable to Recipe Step
            if(Item.RecipeSteps[CurrentPageNumber - 1].HasTimer)
            {
                TimerBlock.IsVisible = true;
                TimerText.Text = Item.RecipeSteps[CurrentPageNumber - 1].TimerMinuteCount.ToString().PadLeft(2, '0')+":"+Item.RecipeSteps[CurrentPageNumber - 1].TimerSecondCount.ToString().PadLeft(2, '0');
            }
        }

        private async Task StartTimer(CancellationToken token, int timerMinuteCount, int timerSecondCount)
        {
            TimerButton.Text = "Stop";

            while (timerSecondCount >= 0 && !token.IsCancellationRequested)
            {
                if (timerSecondCount == 0 && timerMinuteCount != 0)
                {
                    timerSecondCount = 59;
                    timerMinuteCount--;
                }
                Device.BeginInvokeOnMainThread(() => TimerText.Text = timerMinuteCount.ToString().PadLeft(2, '0') +":"+timerSecondCount.ToString().PadLeft(2, '0'));
                await Task.Delay(1000, token);
                
                timerSecondCount--;
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

        private async void TimerButton_Clicked(object sender, EventArgs e)
        {
            if (cts == null)
            {
                cts = new CancellationTokenSource();
                try
                {
                    await StartTimer(cts.Token, Item.RecipeSteps[CurrentPageNumber - 1].TimerMinuteCount, Item.RecipeSteps[CurrentPageNumber - 1].TimerSecondCount);
                }
                catch (OperationCanceledException)
                {

                }
                finally
                {
                    cts = null;
                    TimerButton.Text = "Start";
                }
            }
            else
            {
                cts.Cancel();
                TimerText.Text = Item.RecipeSteps[CurrentPageNumber - 1].TimerMinuteCount.ToString().PadLeft(2, '0') + ":" + Item.RecipeSteps[CurrentPageNumber - 1].TimerSecondCount.ToString().PadLeft(2, '0');
                cts = null;
            }
        }
    }
}