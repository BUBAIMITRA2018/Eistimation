using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using Estimationtool.Models;
using Estimationtool.Views;
using Estimationtool.Services;
using System.Windows.Input;

namespace Estimationtool.ViewModels
{
    class HomeViewModel : BaseViewModel
    {

        private Product _selectedProduct;

        private bool _isRefreshing;

        public IDataStore<Product> DataStore => DependencyService.Get<IDataStore<Product>>() ?? new MockDataStore();

        public ObservableCollection<Product> Products { get; set; }
        public ICommand LoadItemsCommand { get; set; }





        public bool IsRefreshing
        {
            get { return this._isRefreshing; }
            set { this.SetProperty(ref this._isRefreshing, value); }
        }


        public Product SelectedProduct
        {
            get { return this._selectedProduct; }
            set { this.SetProperty(ref this._selectedProduct, value); }
        }



        public HomeViewModel()
        {
            Title = "Home";
            Products = new ObservableCollection<Product>();

           
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            try
            {

                ExecuteLoadItemsCommand();


            }

            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }








            async Task ExecuteLoadItemsCommand()
            {
                if (IsBusy)
                    return;

                IsBusy = true;

                try
                {
                    Products.Clear();
                    var items = await DataStore.GetItemsAsync();
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
}


