using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CrockpotApp.Unit_Tests;
using CrockpotApp.Models;

namespace CrockpotApp.Views
{
    /// <summary>
    /// AboutPage.cs
    /// </summary>
    /// 
    ///<remarks>
    ///The Class for the About Page which holds some details about the app and some Unit Tests.
    /// </remarks>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        /// <summary>
        /// AboutPage Default Constructor
        /// </summary>
        /// 
        ///<remarks>
        ///Loads AboutPage and Creates some Unit Tests.
        /// </remarks>
        public AboutPage()
        {
            InitializeComponent();

            TestIngredientValidity test = new TestIngredientValidity();
            Ingredient ingredientOne = new Ingredient();
            ingredientOne.Quantity = "20";

            Ingredient ingredientTwo = new Ingredient();
            ingredientTwo.Name = "Potato";

            Ingredient ingredientThree = new Ingredient();
            ingredientThree.Name = "";
            
            UNIT_TEST1.Text = ("Expected: False | Actual: "+test.ValidateIngredientName(ingredientOne.Name).ToString()); //SHOULD == FALSE
            UNIT_TEST2.Text = ("Expected: True | Actual: " + test.ValidateIngredientName(ingredientTwo.Name).ToString()); //SHOULD == TRUE
            UNIT_TEST3.Text = ("Expected: True | Actual: " + test.ValidateIngredientName(ingredientThree.Name).ToString());
        }

    }
}