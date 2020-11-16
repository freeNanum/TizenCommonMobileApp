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
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent(); // Tizen: Not support Minimum, Maximum on slide component.

            //initProperty();

#if true
            Binding binding01 = new Binding
            {
                Source = slider21,
                Path = "Value"
            };
            label31.SetBinding(Label.PaddingProperty, binding01);

            Binding binding02 = new Binding
            {
                Source = slider21,
                Path = "Value"
            };
            label32.SetBinding(Label.FontSizeProperty, binding02);

#else
            label31.BindingContext = slider21;
            label32.BindingContext = slider21;

            label31.SetBinding(Label.PaddingProperty, "Value");
            label32.SetBinding(Label.FontSizeProperty, "Value");
#endif
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
                await Navigation.PushAsync(new ThirdPage());
            }
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var Id = ((Slider)sender).Id;
            if(Id == slider01.Id)
            {
                label01.Padding = e.NewValue*40 + 10;//(int)slider01.Value; 
                label02.FontSize = e.NewValue * 50 + 10; // 10<= Value =<30
            }
        }

        private void initProperty()
        {
            label01.Padding = (int)slider01.Value * 40 + 10;//(int)slider01.Value; 
            label02.FontSize = (int)slider01.Value * 20 + 10; // 10<= Value =<30
        }
    }
}