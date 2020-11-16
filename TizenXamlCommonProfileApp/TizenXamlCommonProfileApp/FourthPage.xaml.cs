using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TizenXamlCommonProfileApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FourthPage : ContentPage
    {
        bool originalStyle = true;
        public FourthPage()
        {
            InitializeComponent();
            Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            var Id = ((Button)sender).Id;

            if (Id == btnBack.Id)
            {
                await Navigation.PopAsync();
            }
            else if (Id == btnNext.Id)
            {
                await Navigation.PushAsync(new FifthPage());
            }
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            if (originalStyle)
            {
                Resources["searchBarStyle"] = Resources["greenSearchBarStyle"];
                originalStyle = false;
            }
            else
            {
                Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
                originalStyle = true;
            }
        }
    }
}