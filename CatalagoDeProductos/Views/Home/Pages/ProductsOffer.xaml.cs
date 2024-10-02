using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CatalagoDeProductos.Views.Home.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProductsOffer : ContentPage
	{
		public ProductsOffer ()
		{
			InitializeComponent ();
		}

        private void OfferDetail_Tapped(object sender, EventArgs e)
        {

        }
    }
}