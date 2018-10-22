using CrockpotApp.Unit_Tests;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrockpotApp.Views
{
    /// <summary>
    /// MainPage.cs
    /// </summary>
    /// 
    ///<remarks>
    ///Loads a Tabbed Page including the About Tab and the Recipe Tab. This is where the rest of the app tabs are placed on top of.
    /// </remarks>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
    }
}