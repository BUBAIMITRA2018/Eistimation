using Estimationtool.Models;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Estimationtool.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Home, Title="Home",Icon = "home.png" },
                new HomeMenuItem {Id = MenuItemType.CustomFilter, Title="CustomFilter",Icon = "filter.png" },
                new HomeMenuItem {Id = MenuItemType.Help, Title="Help",Icon = "help.png" },
                new HomeMenuItem {Id = MenuItemType.LogOut, Title="Logout",Icon = "LogOut.png" }

            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);

            };

        }
    }

}
