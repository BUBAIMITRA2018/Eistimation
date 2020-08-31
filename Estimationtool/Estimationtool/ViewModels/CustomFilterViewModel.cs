using Estimationtool.Models;
using Estimationtool.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Estimationtool.ViewModels
{
    class CustomFilterViewModel : BaseViewModel
    {

        private int _selectedIndex1;
        private string _selectedItem1;
        private int _selectedIndex2;
        private string _selectedItem2;


        private Xamarin.Forms.Color _textColor = Xamarin.Forms.Color.Red;

        private Product _selectedProduct;

        private bool _isRefreshing;

        public IDataStore<Product> DataStore => DependencyService.Get<IDataStore<Product>>() ?? new MockDataStore();

        public ObservableCollection<Product> Products { get; set; }
        public List<string> _list1;

        public List<string> _list2;

        public ICommand LoadItemsCommand { get; set; }


        public List<string> List1
        {
            get { return _list1; }



            set => this.SetProperty(ref this._list1, value);
        }


        public List<string> List2
        {
            get { return _list2; }



            set => this.SetProperty(ref this._list2, value);
        }




        public int SelectedIndex1
        {
            get
            {
                return _selectedIndex1;
            }
            set
            {
                 this.SetProperty(ref this._selectedIndex1, value);
               



            }
        }


        public string SelectedItem1
        {
            get
            {
                return _selectedItem1;
            }
            set
            {
                this.SetProperty(ref this._selectedItem1, value);
               List<string> items =   DataStore.AddItemAsync(_selectedItem1);

                List2 = items;

            }
        }

        public int SelectedIndex2
        {
            get
            {
                return _selectedIndex2;
            }
            set
            {
                this.SetProperty(ref this._selectedIndex2, value);
            }
        }


        public string SelectedItem2
        {
            get
            {
                return _selectedItem2;
            }
            set
            {
                this.SetProperty(ref this._selectedItem2, value);

                


            }
        }








 

        public Xamarin.Forms.Color TextColor
        {
            get
            {
                return _textColor;
            }
            set
            {
                this.SetProperty(ref this._textColor, value);
            }
        }


        public CustomFilterViewModel()
        {
           

            SelectedIndex1 = 1;
            ChangeTextColorCommand = new Command(ChangeColor);

            Title = "Home";
            Products = new ObservableCollection<Product>();

            

            var list1 = new List<string>()
                          {
                                 "WBSElement",
                                 "ProductNo",
                                 "MatrialNo",
                                 "Specification"

                          };

            List1 = list1;




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











        public ICommand ChangeTextColorCommand
        {
            get;
        }

        void ChangeColor()
        {
            if (TextColor == Color.Red)
            {
                TextColor = Color.Pink;
            }
            else
            {
                TextColor = Color.Red;
            }
        }
    }
}
