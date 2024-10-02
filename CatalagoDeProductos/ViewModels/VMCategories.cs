using CatalagoDeProductos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Text;

namespace CatalagoDeProductos.ViewModels
{
    public class VMCategories
    {
        public ObservableCollection<Category> MyCategories { get; set; }
        public VMCategories() 
        {
            MyCategories = new ObservableCollection<Category> 
            {
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_car-front-new-category.webp",
                            Name="Autos, Motos y Otros"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_mobile-button-category.webp",
                            Name="Celulares y Teléfonos"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_audio-92-category.webp",
                            Name="Electrónica, Audio y Video"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_ball-soccer-category.webp",
                            Name="Deportes y Fitness"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_tshirt-53-category.webp",
                            Name="Ropa y Accesorios"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_armchair_blue-category.webp",
                            Name="Hogar, Muebles y Jardín"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_tv-2-category.webp",
                            Name="Tecnología y Computación"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_steering-wheel-category.webp",
                            Name="Accesorios para Vehículos"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_oven-category.webp",
                            Name="Electrodomésticos"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_controller-2-category.webp",
                            Name="Consola y Videojuegos"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_watch-circle-category.webp",
                            Name="Joyas y Relojes"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_tvs-category.webp",
                            Name="Televisores"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_guitar-category.webp",
                            Name="Instrumentos Musicales"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_baby-category.webp",
                            Name="Bebés"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_chair-category.webp",
                            Name="Industrias y Oficinas"},
                new Category{Img="https://http2.mlstatic.com/storage/homes-korriban/assets/icons/xxhdpi/home_factory-category.webp",
                            Name="Construcción"}
            };
        }
    }
}
