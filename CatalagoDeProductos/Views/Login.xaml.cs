using CatalagoDeProductos.Views.Home;
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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private async void btn_atras_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
            //await Application.Current.MainPage.Navigation.PushModalAsync(new Login());
            //await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        private async void register_Tapped(object sender, EventArgs e)
        {            
            // Obtener la página actual que se está mostrando de forma modal
            var currentModalPage = Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();

            if (currentModalPage != null)
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            }
            await Application.Current.MainPage.Navigation.PushModalAsync(new Register());
        }

        private async void btn_ingresar_Clicked(object sender, EventArgs e)
        {
            var currentModalPage = Application.Current.MainPage.Navigation.ModalStack.LastOrDefault();
            string email = "tilin@gmail.com";
            string password = "123";

            string e_ingresado = entryEmail.Text;
            string p_ingresado = entryPass.Text;

            if (email==e_ingresado && password==p_ingresado)
            {
                if (currentModalPage != null)
                {
                    await Application.Current.MainPage.Navigation.PopModalAsync();
                }
                await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());
            }
            else
            {
                lbl_login.Text = "Correo o contraseña incorrecta...!";
            }
        }
    }
}