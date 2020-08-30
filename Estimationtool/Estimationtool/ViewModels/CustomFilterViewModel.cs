using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Input;

namespace Estimationtool.ViewModels
{
    class CustomFilterViewModel:BaseViewModel
    {

        private int _selectedIndex;
        private string _selectedItem;
        private Color _textColor = Color.Red;

        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                 this.SetProperty(ref this._selectedIndex, value); 
            }
        }


        public string SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                this.SetProperty(ref this._selectedItem, value);
            }
        }

        public List<string> List { get; private set; }
        public List<string> List2 { get; private set; }

        public Color TextColor
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
            List = new List<string>()
            {
                "WBS Element",
                "Product",
                "Item Desc",
                "Drawing No",
                "Specification",
                "Area Desc",
                "Project",
                "Purchasing Doc",
                "PO Date",
                "PO Vendor",
                "Destination"

            };
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
