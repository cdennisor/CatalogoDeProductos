using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CatalagoDeProductos.CustomResourceDictionary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomResource : ResourceDictionary
    {
        public CustomResource()
        {
            InitializeComponent();
        }
    }
}