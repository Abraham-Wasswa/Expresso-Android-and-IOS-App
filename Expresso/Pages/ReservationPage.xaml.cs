﻿using Expresso.Models;
using Expresso.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Expresso.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReservationPage : ContentPage
    {
        public ReservationPage()
        {
            InitializeComponent();
        }

        private async void BtnBookTable_OnClicked(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation()
            {
                Name = EntName.Text,
                Email = EntEmail.Text,
                Phone = EntPhone.Text,
                TotalPeople = EntTotalPeople.Text,
                Date = DpBookingDate.Date.ToString(),
                Time = TpBookingTime.Time.ToString()
            };
            ApiServices apiServices = new ApiServices();
            bool response = await apiServices.ReservationTable(reservation);

            if(response != true)
            {
                await DisplayAlert("Oops", "Something goes wrong", "Alright");
            }
            else
            {
                await DisplayAlert("Hi", "Your Table has been reserved successfully", "Alright");
            }
        }
    }
}