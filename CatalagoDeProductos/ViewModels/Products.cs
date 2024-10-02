using CatalagoDeProductos.Models;
using System.Collections.ObjectModel;

namespace CatalagoDeProductos.ViewModels
{
    public class Products
    {
        public ObservableCollection<ProductInfo> MyProducts { get; set; }
        public Products() 
        {
            MyProducts = new ObservableCollection<ProductInfo>
            {
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_701976-MPE77058359538_062024-O.webp", 
                    Before="139.90", Price=113.26, Description="Aspiradora Portátil Multifuncional para Coche y Hogar",Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_740263-MLA48765277057_012022-O.webp",
                    Before="120.90", Price=99,Description="Cargador Portátil 20000mah Xioami Power Bank 18w Usb-c",Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_670238-MLU72877828042_112023-O.webp",
                    Before="603.30", Price=549,Description="Monitor LG 24gq50f 24' Va Ultragear 1ms 165hz Freesync Hdmi Color Negro",Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_610363-MLU77795143474_072024-O.webp",
                    Before="588.23", Price=476.46,Description="Coche Cuna Moises 3 Posiciones Niña Niño Color Negro",Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_772095-MPE76752020771_052024-O.webp",
                    Before="769", Price=518,Description="Escalera 16 Peldaños Multiposición + Kit Pintor Fino Truper",Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_944088-MPE48860109537_012022-O.webp",
                    Before="369.90", Price=189,Description="Creatina Monohidratada 1 Kg Kevin Levrone Micronizada 1 Kilo",Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_900485-MPE78121638889_082024-O.webp",
                    Before="150", Price=66,Description="Churu Snack Húmedo Para Gatos Pack X 6 Und",Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_759471-MLA71782897602_092023-O.webp",
                    Before="3995", Price=3235,Description="Apple iPhone 15 (128 GB) - Azul",Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_886329-MPE75598004950_042024-O.webp",
                    Before="3599", Price=2049,Description="Consola Sony Playstation 5 Slim Spiderman Con Lector De Disco", Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_2X_842185-MPE71462542151_092023-E.webp",
                    Before="401.50", Price=281,Description="Hidrolavadora Portatil Truper Truper 1500 Psi + Manguera 10 ", Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_801435-MPE77224665170_072024-O.webp",
                    Before="489", Price=278,Description="Juego De Ollas Oster Raffaelli 8 Piezas Acero Inoxidable", Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_736168-MLA47781742030_102021-O.webp",
                    Before="4669", Price=2649,Description="Apple iPhone 13 (128 GB) - Blanco estelar - Distribuidor Autorizado", Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_619550-MLU73873288022_012024-O.webp",
                    Before="2099", Price=1139,Description="Silla De Oficina Giratoria Bonno Presidente Nefi Color Negro", Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_938721-MLA74746932815_022024-O.webp",
                    Before="225", Price=190,Description="Mochila Arctic Hunter B00388 Deportiva Impermeable Viaje Laptop 27L Negro", Detail="Envio gratis"},
                new ProductInfo{Img="https://http2.mlstatic.com/D_NQ_NP_866900-MPE72117131475_102023-O.webp",
                    Before="99.90", Price=74.92,Description="Lentes Magneticos 6 En 1 Montura Para Medida Optica Imantada", Detail="Envio gratis"}
            };
        }
    }
}
