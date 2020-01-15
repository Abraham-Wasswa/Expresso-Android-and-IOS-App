using Expresso.Services;
using System;
using System.Collections.ObjectModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Menu = Expresso.Models.Menu;

namespace Expresso.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public ObservableCollection<Menu> Menus;

        public static bool First = true;
        public MenuPage()
        {
            InitializeComponent();
            Menus = new ObservableCollection<Menu>();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (First)
            {
                ApiServices apiServices = new ApiServices();
                var menus = await apiServices.GetMenu();

                foreach (var menu in menus)
                {
                    Menus.Add(menu);
                }

                LvMenu.ItemsSource = Menus;
                BusyIdicator.IsRunning = false;
            }

            First = false;
        }

        private void LvMenu_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var SelectedMenu = e.SelectedItem as Menu;
            if(SelectedMenu != null)
            {
                Navigation.PushAsync(new SubMenuPage(SelectedMenu));
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}