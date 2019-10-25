using System;
using System.Collections.Generic;
using System.Text;

namespace GradebookFinal.Models
{
    public enum MenuItemType
    {
        Home,
        Browse,
        About,
        Dashboard,
        Settings,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
