using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.Xaml;

namespace Expresso.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage
    {
        [Obsolete]
        public HomePage()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom)
                         .SetBarItemColor(Color.Black)
                         .SetBarSelectedItemColor(Color.Pink);
        }
    }
}