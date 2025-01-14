﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CatalagoDeProductos.Models;
using CatalagoDeProductos.Views.Home.Pages;

namespace CatalagoDeProductos.Views.Home
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : FlyoutPage
	{
		public MainPage()
		{
			InitializeComponent();
            //this.Flyout = new Flyout();
            //this.Detail = new NavigationPage (new Detail());
            //App.MasterDet = this;

            flyout.MenuItemsListView.ItemSelected += OnSelectedItem;
		}

		private void OnSelectedItem(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as FlyoutItemPage;
			if (item != null) 
			{
				Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage));
				flyout.MenuItemsListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}