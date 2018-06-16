using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ArTai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        Sound allSounds = new Sound();

        public InfoPage()
        {
            InitializeComponent();
            //1
            TitleLabel_1.Text      = Global.HowToLabeltitle1;
            GameLabel_1.Text       = Global.HowToLabeltext1;
            TitleLabel_1.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            GameLabel_1.TextColor  = Color.FromHex(Global.ButtonTextWhiteColor);
            //2
            TitleLabel_2.Text      = Global.HowToLabeltitle2;
            GameLabel_2.Text       = Global.HowToLabeltext2;
            TitleLabel_2.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            GameLabel_2.TextColor  = Color.FromHex(Global.ButtonTextWhiteColor);


        }
        protected override void OnAppearing()
        {
            allSounds.OpenSettingssound();

            base.OnAppearing();
        }
        protected override void OnDisappearing()

        {
            allSounds.CloseSettingssound();

            base.OnDisappearing();
        }

    }
}