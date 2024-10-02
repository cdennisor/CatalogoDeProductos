using CatalagoDeProductos.Models;
using CatalagoDeProductos.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.WebRequestMethods;

namespace CatalagoDeProductos.Views.Home.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        ObservableCollection<ProductInfo> MyOffers;
        public HomePage ()
		{
			InitializeComponent ();
            MyOffers = new ObservableCollection<ProductInfo>
            {
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_895289-MPE51092607930_082022-O.webp", 
                    Before="259", Price=179,Description="Zapatillas Adidas Hombre", Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_794102-MLM48931423148_012022-O.webp", 
                    Before="150", Price=109,Description="Xiaomi Cargador 20W Tipo-C", Detail="Envio gratis"},
                new ProductInfo{Img="https://miportal.entel.pe/static/080520241423484/images/Apple_Watch_Ultra_2_GPS+Cellular_49_MM_Correa_Trail_AzulNegra_Frontal2_276x549.jpg",
                    Before="4299", Price=3499,Description="Apple Watch Ultra 2", Detail="Envio gratis"},
                new ProductInfo{Img="https://coolboxpe.vtexassets.com/arquivos/ids/375851/image-f8711e164a0942d08665ce0d2739216a.jpg",
                    Before="399", Price=349,Description="Audífonos Inalámbricos Huawei", Detail="Envio gratis"},
                new ProductInfo{Img="https://xiaomioficial.pe/media/catalog/product/X/I/XIA0002033_1.jpg",
                    Before="1692", Price=1539,Description="Xiaomi Redmi Note 13", Detail="Envio gratis"},
                new ProductInfo{Img="https://imagedelivery.net/4fYuQyy-r8_rpBpcY7lH_A/falabellaPE/120966494_01/w=800,h=800,fit=pad",
                    Before="370", Price=229,Description="Taladro Percutor 24v", Detail="Envio gratis"}
            };

            myCollectionH.ItemsSource = MyOffers;
        }

        private async void myCollectionH_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Obtiene el primer elemento seleccionado de la colección
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as ProductInfo;

            // Verifica si el producto seleccionado no es nulo
            if (selectedProduct != null)
            {
                // Crea una instancia de la página de detalles
                var productPage = new ProductDetail();

                // Establece el BindingContext de la página de detalles
                productPage.BindingContext = selectedProduct;

                // Navega a la página de detalles
                await Navigation.PushModalAsync(productPage);
            }

            // Opcionalmente, puedes deseleccionar el ítem para evitar que permanezca seleccionado
            ((CollectionView)sender).SelectedItem = null;
        }

        private void search_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filteredList = MyOffers.Where(a => a.Description.StartsWith(e.NewTextValue));
            myCollectionH.ItemsSource = filteredList;
        }
    }
}