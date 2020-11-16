using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenXamlCommonProfileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new TizenXamlCommonProfileApp.MainPage();

            /* Page navigation */
            MainPage = new NavigationPage(new FirstPage());

#if DEBUG
            TizenHotReloader.HotReloader.Open(this);
#endif
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
