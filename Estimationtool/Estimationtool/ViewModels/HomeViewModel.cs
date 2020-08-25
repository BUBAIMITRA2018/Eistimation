using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Estimationtool.Models;
using Estimationtool.Views;
using Estimationtool.Services;

namespace Estimationtool.ViewModels
{
    class HomeViewModel : BaseViewModel
    {

        private Product _selectedProduct;

        private bool _isRefreshing;

        public IDataStore<Product> DataStore => DependencyService.Get<IDataStore<Product>>() ?? new MockDataStore();

        public ObservableCollection<Product> Products { get; set; }
        public Command LoadItemsCommand { get; set; }





        public HomeViewModel()
        {
            Title = "Home";
            Products = new ObservableCollection<Product>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

        }


        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Products.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Products.Add(item);
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
