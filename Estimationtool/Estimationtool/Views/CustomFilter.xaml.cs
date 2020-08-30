using Estimationtool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.ComboBox;
using Xamarin.Forms.Xaml;

namespace Estimationtool.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomFilter : ContentPage
	{
		public CustomFilter ()
		{
			InitializeComponent ();
            BindingContext = new CustomFilterViewModel();

        }

        private void Combo1_SelectedIndexChanged(object sender, SelectedIndexChangedEventArgs e)
        {
            //lbl_combo1.Text = $"Combo1 old index : {e.OldIndex} new index : {e.NewIndex}. Selected Item '{_comboBox1.SelectedItem}'";
        }
    }
}