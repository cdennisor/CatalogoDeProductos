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
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();

            //Grid myGrid = new Grid
            //{
            //    RowSpacing = 1,
            //    ColumnSpacing = 3,
            //    RowDefinitions =
            //    {
            //        new RowDefinition{Height = new GridLength(1,GridUnitType.Auto)},
            //        new RowDefinition{Height = new GridLength(75)},
            //        new RowDefinition{Height = new GridLength(1,GridUnitType.Star)},
            //        new RowDefinition{Height = new GridLength(150)}
            //    },
            //    ColumnDefinitions =
            //    {
            //        new ColumnDefinition{Width = new GridLength(75)},
            //        new ColumnDefinition{Width = new GridLength(100)},
            //        //new RowDefinition{Height = new GridLength(1,GridUnitType.Star)},
            //    }

            //};
            //startPageGrid = myGrid;
        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Login());
        }

        private async void btn_register_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Register());
        }

        private void invited(object sender, EventArgs e)
        {
            Navigation.PushModalAsync (new MainPage());
        }
    }
}