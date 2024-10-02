using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CatalagoDeProductos.Views;
using CatalagoDeProductos.Views.Home;
using CatalagoDeProductos.Views.Home.Pages;

namespace CatalagoDeProductos
{
    public partial class App : Application
    {
        //public static FlyoutPage MasterDet { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
