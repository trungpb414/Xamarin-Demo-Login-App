using System;
using System.Collections.Generic;
using LoginApp.ViewModel;
using Xamarin.Forms;

namespace LoginApp
{
    public partial class LoginPage : ContentPage
    {
        LoginPageViewModel loginVM;
        public LoginPage()
        {
            InitializeComponent();
            loginVM = new LoginPageViewModel();
            BindingContext = loginVM;
        }
    }
}

