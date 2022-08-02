using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace LoginApp.ViewModel
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {

        private String email;

        public String Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
            }
        }

        private String password;

        public String Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public LoginPageViewModel()
        {
            email = "";
            password = "";
        }

        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }
        }

        private void Login()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                App.Current.MainPage.DisplayAlert("Empty values", "Please enter data", "Ok");
            }
            else
            {
                Console.WriteLine(Email);
                Console.WriteLine(Password);
                App.Current.MainPage = new MainPage(Email, Password);
            }
        }

    }
}

