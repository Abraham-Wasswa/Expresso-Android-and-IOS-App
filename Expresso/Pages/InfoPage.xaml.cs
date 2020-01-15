using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Expresso.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        public InfoPage()
        {
            InitializeComponent();
        }

        private void TapFacebook_OnTapped(Object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/communitycoffeepage/"));
        }

        private void TapTwitter_OnTapped(Object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/communitycoffeepage/"));
        }

        private void TapInstagram_OnTapped(Object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.facebook.com/communitycoffeepage/"));
        }

        private void TapYoutube_OnTapped(Object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.youtube.com/watch?v=slgEYXJ1sZQ"));
        }

        private void TapCall_OnTapped(Object sender, EventArgs e)
        {
            PhoneDialer.Open("+12532927525");
        }
    }
}