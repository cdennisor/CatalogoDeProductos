using CatalagoDeProductos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CatalagoDeProductos.ViewModels
{
    public class ProductsOff
    {
        public ObservableCollection<ProductInfo> MyOffers { get; set; }
        public ProductsOff()
        {
            MyOffers = new ObservableCollection<ProductInfo>
            {
                new ProductInfo{Img="https://www.efe.com.pe/media/catalog/product/p/s/ps5-slim-spidja_1_1.jpg", 
                    Before="3599", Price=2049,Description="Consola Sony Playsation 5", Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_2X_842185-MPE71462542151_092023-E.webp", 
                    Before="401.50", Price=281,Description="Hidrolavadora Portátil", Detail="Envio gratis"},
                new ProductInfo{Img="https://promart.vteximg.com.br/arquivos/ids/7454606-1000-1000/image-07a798ec142f4ffb8f7a9ddcbffbae24.jpg", 
                    Before="489", Price=278,Description="Juego De Ollas Oster", Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_736168-MLA47781742030_102021-O.webp", 
                    Before="4669", Price=2649,Description="Apple Iphone 13", Detail="Envio gratis"},
                new ProductInfo{Img="https://miportal.entel.pe/static/080520241423484/images/Apple_Watch_Ultra_2_GPS+Cellular_49_MM_Correa_Trail_AzulNegra_Frontal2_276x549.jpg", 
                    Before="4299", Price=3499,Description="Apple Watch Ultra 2", Detail="Envio gratis"},
                new ProductInfo{Img="https://coolboxpe.vtexassets.com/arquivos/ids/375851/image-f8711e164a0942d08665ce0d2739216a.jpg", 
                    Before="399", Price=349,Description="Audífonos Inalámbricos Huawei", Detail="Envio gratis"},
                new ProductInfo{Img="https://xiaomioficial.pe/media/catalog/product/X/I/XIA0002033_1.jpg", 
                    Before="1692", Price=1539,Description="Xiaomi Redmi Note 13", Detail="Envio gratis"},
                new ProductInfo{Img="https://imagedelivery.net/4fYuQyy-r8_rpBpcY7lH_A/falabellaPE/120966494_01/w=800,h=800,fit=pad", 
                    Before="370", Price=229,Description="Taladro Percutor 24v", Detail="Envio gratis"},
                new ProductInfo{Img="https://global.machenike.com/cdn/shop/products/1_1.png?v=1661592419", 
                    Before="284.28", Price=198.99,Description="Teclado Gamer Machenike", Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_610242-MPE48307321586_112021-O.webp",
                    Before="150", Price=103, Description="Máscara De Soldar Con Visor", Detail="Envio gratis"}
            };
            
        }
    }
}
