using System;
using System.Collections.Generic;
using System.Text;

namespace Adhydro_link.Models
{
    //add more items for pages to login and change
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
