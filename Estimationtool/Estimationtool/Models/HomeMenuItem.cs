using System;
using System.Collections.Generic;
using System.Text;

namespace Estimationtool.Models
{
    public enum MenuItemType
    {
        Home,
        CustomFilter,
        Help
        
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }

        public string Icon { get; set; }

    }
}
