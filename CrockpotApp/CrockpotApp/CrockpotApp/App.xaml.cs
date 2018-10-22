using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CrockpotApp.Views;
using CrockpotApp.Unit_Tests;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace CrockpotApp
{
    /// <summary>
    /// App.cs - The App Class is the the first class executed on opening of the App where it launches the main first page.
    /// </summary>
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();                       
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
