using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginApp.ViewModel
{
    public class YamahaSettingPageViewModel : INotifyPropertyChanged
    {
        private ICommand userProfileTapCommand;
        private ICommand accountControlTapCommand;
        private ICommand faqsTapCommand;
        private ICommand tutorialTapCommand;
        private ICommand contactTapCommand;
        private ICommand shareTapCommand;
        private ICommand rateTapCommand;
        //private ICommand switchCommand;

        public YamahaSettingPageViewModel()
        {
            userProfileTapCommand = new Command(onItemTap);
            accountControlTapCommand = new Command(onItemTap);
            faqsTapCommand = new Command(onItemTap);
            tutorialTapCommand = new Command(onItemTap);
            contactTapCommand = new Command(onItemTap);
            shareTapCommand = new Command(onItemTap);
            rateTapCommand = new Command(onItemTap);
            //switchCommand = new Command(onSwitch);
        }

        public ICommand UserProfileTapCommand
        {
            get { return userProfileTapCommand; }
        }

        public ICommand AccountControlTapCommand
        {
            get { return accountControlTapCommand; }
        }

        public ICommand FaqsTapCommand
        {
            get { return faqsTapCommand; }
        }

        public ICommand TutorialTapCommand
        {
            get { return tutorialTapCommand; }
        }

        public ICommand ContactTapCommand
        {
            get { return contactTapCommand; }
        }

        public ICommand ShareTapCommand
        {
            get { return shareTapCommand; }
        }

        public ICommand RateTapCommand
        {
            get { return rateTapCommand; }
        }

        //public ICommand SwitchCommand
        //{
        //    get { return switchCommand; }
        //}

        private void onItemTap(object obj)
        {
            Console.WriteLine("Tapped ok");

        }

        //private void onSwitch(object obj)
        //{
        //    Console.WriteLine("Switch ok");
        //}

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

