using System;

using Xamarin.Forms.Issue._11066._11077.Models;

namespace Xamarin.Forms.Issue._11066._11077.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
