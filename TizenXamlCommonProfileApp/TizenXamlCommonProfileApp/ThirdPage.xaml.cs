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
    public partial class ThirdPage : ContentPage
    {
        public ThirdPage()
        {
            InitializeComponent();
        }

        public class ResouceCS
        {
            //Text color - Static Resource in C#
            public static Color TextColorWhiteCS = Color.FromHex("#fff");
            public static Color TextColorGrayCS = Color.FromHex("#0f0");
            public static Color TextColorGreenCS = Color.FromHex("#0f0");

        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            var Id = ((Button)sender).Id;

            //Navigation
            if (Id == btnBack.Id)
            {
                await Navigation.PopAsync();
            }
            else if (Id == btnNext.Id)
            {
                await Navigation.PushAsync(new FourthPage());
            }

            //Background Color
            if(Id == btnBColorRed.Id)
            {
                labelHello.BackgroundColor = (Color)this.Resources["pageBackgroundColorRed"];
            }
            else if(Id == btnBColorGreen.Id)
            {
                labelHello.BackgroundColor = (Color)this.Resources["pageBackgroundColorGreen"];
            }
            else if(Id == btnBColorBlue.Id)
            {
                labelHello.BackgroundColor = (Color)this.Resources["pageBackgroundColorBlue"];
            }

            //Padding
            if (Id == btnPaddingBig.Id)
            {
                labelHello.Padding = new Thickness((Double)this.Resources["pagePaddingBig"]);
            }
            else if (Id == btnPaddingNormal.Id)
            {
                labelHello.Padding = new Thickness((Double)this.Resources["pagePaddingNormal"]);
            }
            else if (Id == btnPaddingSmall.Id)
            {
                labelHello.Padding = new Thickness((Double)this.Resources["pagePaddingSmall"]);
            }

            //Font Size
            if (Id == btnFontSizeBig.Id)
            {
                labelHello.FontSize = 30;// (Double)this.Resources["pageFontSizeBig"];
            }
            else if (Id == btnFontSizeNormal.Id)
            {
                labelHello.FontSize = 20; // (Double)this.Resources["pageFontSizeNormal"];
            }
            else if (Id == btnFontSizeSmall.Id)
            {
                labelHello.FontSize = 10; // (Double)this.Resources["pageFontSizeSmall"];
            }

            //Text color
            if (Id == pageTColorWhite.Id)
            {
                labelHello.TextColor = (Color)this.Resources["pageTextColorWhite"];
            }
            else if (Id == pageTColorBlack.Id)
            {
                labelHello.TextColor = (Color)this.Resources["pageTextColorBlack"];
            }
            else if (Id == pageTColorGray.Id)
            {
                labelHello.TextColor = (Color)this.Resources["pageTextColorGray"];
            }

            //Font Attribute
            if (Id == pageFontAttributeBold.Id)
            {
                labelHello.FontAttributes = FontAttributes.Bold;
            }
            else if (Id == pageFontAttributeItalic.Id)
            {
                labelHello.FontAttributes = FontAttributes.Italic;
            }
            else if (Id == pageFontAttributeBI.Id)
            {
                labelHello.FontAttributes = FontAttributes.Bold | FontAttributes.Italic;
            }

        }
    }
}