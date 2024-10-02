using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CatalagoDeProductos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Register : ContentPage
	{
		public Register ()
		{
			InitializeComponent ();
		}

        private async void btn_close_Clicked(object sender, EventArgs e)
        {
			await Navigation.PopModalAsync();
        }

        private async void sign_in_Tapped(object sender, EventArgs e)
        {
            var currentModalPage = Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

            if (currentModalPage != null)
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            }
            await Application.Current.MainPage.Navigation.PushModalAsync(new Login());
        }
    }
}