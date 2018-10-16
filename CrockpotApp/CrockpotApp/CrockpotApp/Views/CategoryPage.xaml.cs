using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using CrockpotApp.ViewModels;
using CrockpotApp.Models;
using System.Collections.ObjectModel;

namespace CrockpotApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        List<string> ingredientArray { get; set; }
         
        public Command NavigateCommand
        {
            private set; get;
        }

        public Command NavigateIngredientCommand
        {
            private set; get;
        }

        public CategoryPage()
        {
            InitializeComponent();

            ingredientArray = new List<string>();
                        
            NavigateCommand = new Command<string>(async (string mealType) =>
            {
                await Navigation.PushAsync(new ItemsPage(mealType));
            });

            NavigateIngredientCommand = new Command<string>(async (string ingredient) =>
            {
                await Navigation.PushAsync(new ItemsPage(ingredient, 1));
            });

            BindingContext = this;
        }

        public CategoryPage(ObservableCollection<Recipe> Items)
        {
            InitializeComponent();

            ingredientArray = new List<string>();

            bool Exists = false;

            foreach (var item in Items)
            {
                foreach (var ingredient in item.IngredientList)
                {
                    foreach (var CurrentIngredient in ingredientArray)
                    {
                        if(CurrentIngredient.Equals(ingredient.Name))
                        {
                            Exists = true;
                        }
                    }

                    if (!Exists)
                    {
                        ingredientArray.Add(ingredient.Name);
                    }
                    else
                    {
                        Exists = false;
                    }
                }
            }
            
            NavigateCommand = new Command<string>(async (string mealType) =>
            {
                await Navigation.PushAsync(new ItemsPage(mealType));
            });

            NavigateIngredientCommand = new Command<string>(async (string ingredient) =>
            {
                await Navigation.PushAsync(new ItemsPage(ingredient, 1));
            });

            BindingContext = this;
            Title = "Search";
        }

        private void SearchButton_Clicked(object sender, EventArgs e)
        {
            string searchedIngredient = SearchBar.Text;
            bool IsFound = false;

            if (SearchBar.Text.ToUpper().Equals("SEARCH INGREDIENTS") || SearchBar.Text.Equals(""))
            {
                SearchBar.Text = "Not Found, Try Again";
                SearchBar.TextColor = Color.Red;
            }
            else
            {
                foreach (var ingredients in ingredientArray)
                {
                    if(!IsFound)
                    {
                        if (searchedIngredient.ToUpper().Contains(ingredients.ToUpper()) || ingredients.ToUpper().Contains(searchedIngredient.ToUpper()))
                        {
                            SearchBar.Text = searchedIngredient;
                            SearchBar.TextColor = Color.Green;
                            IsFound = true;
                            NavigateIngredientCommand.Execute(searchedIngredient);
                        }
                        else
                        {
                            SearchBar.Text = "No Recipes Found, Try Again";
                            SearchBar.TextColor = Color.Red;
                        }
                    }
                }
            }          
                        
        }

        private void SearchBar_Focused(object sender, FocusEventArgs e)
        {
            SearchBar.Text = "";
            SearchBar.TextColor = Color.Black;
        }

        async private void BackButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}