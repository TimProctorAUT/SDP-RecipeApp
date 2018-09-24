using CrockpotApp.Unit_Tests;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrockpotApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}