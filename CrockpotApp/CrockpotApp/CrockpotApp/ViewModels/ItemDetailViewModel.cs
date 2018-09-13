using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using CrockpotApp.Models;
using Xamarin.Forms;

namespace CrockpotApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Recipe Item { get; set; }
        public ObservableCollection<Ingredient> IngredientList { get; set; }
        public Command LoadIngredientCommand { get; set; }
        public ItemDetailViewModel(Recipe item = null)
        {
            Title = item?.Text;
            Item = item;
            IngredientList = new ObservableCollection<Ingredient>();
            LoadIngredientCommand = new Command(async () => await ExecuteLoadIngredientCommand());
        }
        async Task ExecuteLoadIngredientCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                IngredientList.Clear();
                var items = await DataStore.GetItemAsync(Item.Id);
                foreach (var ingredient in items.IngredientList)
                {
                    IngredientList.Add(ingredient);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
