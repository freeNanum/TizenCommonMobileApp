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
    public partial class SeventhPage : ContentPage
    {
        public SeventhPage()
        {
            InitializeComponent();
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
                await Navigation.PushAsync(new LastPage());
            }
        }
    }
}