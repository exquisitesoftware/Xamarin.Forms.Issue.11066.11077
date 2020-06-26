using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.Issue._11066._11077.Models
{
    public enum MenuItemType
    {
        Browse,
        About
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
