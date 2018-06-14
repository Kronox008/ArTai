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
        public InfoPage()
        {
            InitializeComponent();
            //1
            TitleLabel_1.Text = Global.HowToLabeltitle1;
            GameLabel_1.Text = Global.HowToLabeltext1;
            TitleLabel_1.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            GameLabel_1.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            //2
            TitleLabel_2.Text = Global.HowToLabeltitle2;
            GameLabel_2.Text = Global.HowToLabeltext2;
            TitleLabel_2.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            GameLabel_2.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);


        }
        protected override void OnAppearing()
        {
            Sound make_settings_sound = new Sound();
            make_settings_sound.SettingsSoundStream();
            make_settings_sound.SettingsSoundPlay();

            base.OnAppearing();
        }
        protected override void OnDisappearing()

        {
            Sound make_closing_sound = new Sound();
            make_closing_sound.SettingsClosingSoundStream();
            make_closing_sound.SettingsCloseSoundPlay();
            base.OnDisappearing();
        }

    }
}