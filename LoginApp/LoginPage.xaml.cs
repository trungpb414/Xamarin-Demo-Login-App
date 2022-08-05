using System;
using System.Collections.Generic;
using LoginApp.ViewModel;
using Xamarin.Forms;

namespace LoginApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginPageViewModel();
        }
    }
}

