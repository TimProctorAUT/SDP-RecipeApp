using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrockpotApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPage : ContentPage
    {
        public Command NavigateCommand
        {
            private set; get;
        }

        public CategoryPage()
        {
            InitializeComponent();

            NavigateCommand = new Command<string>(async (string mealType) =>
            {
                await Navigation.PushAsync(new ItemsPage(mealType));
            });

            BindingContext = this;
        }

    }
}