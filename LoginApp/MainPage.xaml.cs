using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage(String email, String password)
        {
            InitializeComponent();
            Email.Text = email;
            Password.Text = password;
        }
    }
}

