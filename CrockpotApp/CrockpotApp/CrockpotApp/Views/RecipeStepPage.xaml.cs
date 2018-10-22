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
    /// <summary>
    /// 
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RecipeStepPage : ContentPage
    {
        RecipeStepViewModel viewModel;
        public int CurrentPageNumber { get; set; }
        public int TotalPageCount { get; set; }
        Recipe Item { get; set; }

        CancellationTokenSource cts;

        public int CurrentMinutes { get; set; }
        public int CurrentSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RecipeStepPage()
        {
            CurrentPageNumber = 0;
            TotalPageCount = 0;

            InitializeComponent();

            BindingContext = viewModel = new RecipeStepViewModel(CurrentPageNumber, TotalPageCount, null);
        }

        /// <summary>
        /// RecipeStepPage Constructor
        /// </summary>
        /// 
        /// <param name="item"></param>
        /// <param name="PageNumber"></param>
        /// <param name="TotalPages"></param>
        /// 
        ///<remarks>
        /// Takes In a Recipe Object, and Two Integers representing the Current Step Number and the Total amount of steps
        /// </remarks>
        public RecipeStepPage(Recipe item, int PageNumber, int TotalPages)
        {
            InitializeComponent();

            CurrentPageNumber = PageNumber;
            TotalPageCount = TotalPages;
            Item = item;

            InstructionText.Text = Item.RecipeSteps[CurrentPageNumber - 1].InstructionText;
            StepTitle.Text = Item.RecipeSteps[CurrentPageNumber - 1].Title;

            BindingContext = viewModel = new RecipeStepViewModel(CurrentPageNumber, TotalPageCount, Item);

            CurrentSeconds = Item.RecipeSteps[CurrentPageNumber - 1].TimerSecondCount;
            CurrentMinutes = Item.RecipeSteps[CurrentPageNumber - 1].TimerMinuteCount;

            LoadRecipeImage();


            if (CurrentPageNumber == TotalPageCount)
            {
                NextStep.Text = "Finish";
            }

            //Enable Timer if Applicable to Recipe Step
            if (Item.RecipeSteps[CurrentPageNumber - 1].HasTimer)
            {
                TimerBlock.IsVisible = true;
                TimerText.Text = Item.RecipeSteps[CurrentPageNumber - 1].TimerMinuteCount.ToString().PadLeft(2, '0') + ":" + Item.RecipeSteps[CurrentPageNumber - 1].TimerSecondCount.ToString().PadLeft(2, '0');
            }
        }

        /// <summary>
        /// LoadRecipeImage Method
        /// </summary>
        /// 
        ///<remarks>
        ///Loads an Image from the Recipe Objects set File of else Loads in the Placeholder Image if nothing is available.
        /// </remarks>
        private void LoadRecipeImage()
        {
            if (Item.ImageURL == null || Item.ImageURL == "")
            {
                Item.ImageURL = "placeholder.png";
                MainImage.Source = ImageSource.FromFile(Item.ImageURL);
            }
            else
            {
                MainImage.Source = ImageSource.FromFile(Item.ImageURL);
            }
        }

        /// <summary>
        /// StartTimer Method
        /// </summary>
        /// 
        /// <remarks>
        /// This Method Is used to count down the seconds and Minute set in the current recipe steps
        /// </remarks>
        /// 
        /// <param name="token"></param>
        /// <param name="timerMinuteCount"></param>
        /// <param name="timerSecondCount"></param>
        /// 
        /// <returns>
        /// Task Object - Used For Threading and Async
        /// </returns>
        private async Task StartTimer(CancellationToken token, int timerMinuteCount, int timerSecondCount)
        {
            TimerButton.Text = "Stop";
            PauseButton.IsVisible = true;
                        
            while (timerSecondCount >= 0 && !token.IsCancellationRequested) //While Loop to Count Down Until Minutes and Seconds both == 0
            {                
                if (timerSecondCount == 0 && timerMinuteCount != 0) //turns seconds to 59 if seconds reach zero and minutes isn't  
                {
                    timerSecondCount = 59;
                    timerMinuteCount--;
                }
                Device.BeginInvokeOnMainThread(() => TimerText.Text = timerMinuteCount.ToString().PadLeft(2, '0') + ":" + timerSecondCount.ToString().PadLeft(2, '0'));
                await Task.Delay(1000, token);  //1 Second Delay
                               
                timerSecondCount--;
                CurrentMinutes = timerMinuteCount;
                CurrentSeconds = timerSecondCount;

                if (timerSecondCount == 0 && timerMinuteCount == 0)
                {
                    TimerText.Text = "Complete!";
                    await Task.Delay(500, token);
                    TimerText.TextColor = Color.Green;
                    await Task.Delay(500, token);
                    TimerText.TextColor = Color.Yellow;
                    await Task.Delay(500, token);
                    TimerText.TextColor = Color.Gold;
                    await Task.Delay(500, token);
                    TimerText.TextColor = Color.Blue;
                    await Task.Delay(500, token);
                    TimerText.TextColor = Color.Red;
                    await Task.Delay(500, token);
                    TimerText.TextColor = Color.Indigo;
                    await Task.Delay(500, token);
                    TimerText.TextColor = Color.Black;

                    CancelTimer();
                }

            }

            
        }

        /// <summary>
        /// TimerButton_Clicked Method
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        /// <remarks>
        /// A Method used when the TimerButton is Clicked. This Method will Play or Stop/Reset the Timer depending on it's current state.
        /// </remarks>
        private async void TimerButton_Clicked(object sender, EventArgs e)
        {
            if (cts == null) //Tests if a CancellationToken Has been Already Created
            {
                cts = new CancellationTokenSource();
                try
                {
                    await StartTimer(cts.Token, CurrentMinutes, CurrentSeconds);
                }
                catch (OperationCanceledException)
                {
                    
                }
                finally
                {
                    cts = null;
                    PauseButton.IsVisible = false;
                }
            }
            else  //If a CancelationToken had been Created already.
            {
                CancelTimer();
            }
        }

        private void CancelTimer()
        {
            cts.Cancel(); //Cancel Timer Function
            TimerButton.Text = "Start"; //TimerButton == Start (Has been changed to 'Stop' in StartTimer)
            CurrentMinutes = Item.RecipeSteps[CurrentPageNumber - 1].TimerMinuteCount;  //Resets CurrentMinutes to the Max
            CurrentSeconds = Item.RecipeSteps[CurrentPageNumber - 1].TimerSecondCount;  //Resets CurrentSeconds to the Max
            TimerText.Text = CurrentMinutes.ToString().PadLeft(2, '0') + ":" + CurrentSeconds.ToString().PadLeft(2, '0'); //Resets Timer to Max Minutes and Seconds
            cts = null;
        }

        /// <summary>
        /// PauseButton_Clicked
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        ///<remarks>
        /// This Method Stops the Counter and leaves the Number at the Current Count OR Pausing the Timer.
        ///</remarks>
        private async void PauseButton_Clicked(object sender, EventArgs e)
        {
            if (cts == null)
            {
                cts = new CancellationTokenSource();
                try
                {
                    await StartTimer(cts.Token, CurrentMinutes, CurrentSeconds);
                }
                catch (OperationCanceledException)
                {

                }
                finally
                {
                    cts = null;
                    PauseButton.IsVisible = false;
                }
            }
            else
            {
                cts.Cancel();
                TimerButton.Text = "Resume";
                cts = null;
            }
        }


        /// <summary>
        /// NextStep_Clicked Method
        /// </summary>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        ///<remarks>
        ///Method Loads next RecipeStep in the Line or closes RecipeSteps if on Final Page.
        /// </remarks>
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

        /// <summary>
        /// Back_Clicked Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        ///<remarks>
        ///Returns to Last Opened Page
        /// </remarks>
        async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }


    }
}

