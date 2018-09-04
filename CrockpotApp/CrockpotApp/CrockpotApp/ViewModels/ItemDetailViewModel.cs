using System;

using CrockpotApp.Models;

namespace CrockpotApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Recipe Item { get; set; }
        public ItemDetailViewModel(Recipe item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
