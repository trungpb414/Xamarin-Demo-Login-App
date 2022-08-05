using System;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;


using Xamarin.Forms;
using LoginApp.ViewModel;

namespace LoginApp
{
    public partial class YamahaSettingPage : ContentPage
    {

        public YamahaSettingPage()
        {
            InitializeComponent();
            On<iOS>().SetUseSafeArea(true);
            BindingContext = new YamahaSettingPageViewModel();

            //var userProfileTapGestureRecognizer = new TapGestureRecognizer();
            //userProfileTapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "UserProfileTapCommand");
            //userProfile.GestureRecognizers.Add(userProfileTapGestureRecognizer);

            //var accountControlTapGestureRecognizer = new TapGestureRecognizer();
            //accountControlTapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "AccountControlTapCommand");
            //accountControl.GestureRecognizers.Add(accountControlTapGestureRecognizer);

            //var faqsTapGestureRecognizer = new TapGestureRecognizer();
            //faqsTapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "FaqsTapCommand");
            //faqs.GestureRecognizers.Add(faqsTapGestureRecognizer);

            //var tutorialTapGestureRecognizer = new TapGestureRecognizer();
            //tutorialTapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "TutorialTapCommand");
            //tutorial.GestureRecognizers.Add(tutorialTapGestureRecognizer);

            //var contactTapGestureRecognizer = new TapGestureRecognizer();
            //contactTapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "ContactTapCommand");
            //contact.GestureRecognizers.Add(contactTapGestureRecognizer);

            //var shareTapGestureRecognizer = new TapGestureRecognizer();
            //shareTapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "ShareTapCommand");
            //share.GestureRecognizers.Add(shareTapGestureRecognizer);

            //var rateTapGestureRecognizer = new TapGestureRecognizer();
            //rateTapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "RateTapCommand");
            //rate.GestureRecognizers.Add(rateTapGestureRecognizer);
        }

        void Switch_Toggled(System.Object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            Console.WriteLine("switch btn ok");
        }

        void Switch_Toggled_1(System.Object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            Console.WriteLine("Switch 2");
        }

    }
}

