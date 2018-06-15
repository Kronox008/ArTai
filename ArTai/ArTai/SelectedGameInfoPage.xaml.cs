using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ArTai.Decks;
//using Plugin.SimpleAudioPlayer.Abstractions;
using System.Reflection;
using System.IO;
using FFImageLoading.Forms;
using Plugin.SimpleAudioPlayer;

namespace ArTai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectedGameInfoPage : ContentPage
    {

        Sound allSounds = new Sound();

        ISimpleAudioPlayer GOT_Theme_00; ISimpleAudioPlayer GOT_Theme_01;

        ISimpleAudioPlayer LORD_Theme_00; ISimpleAudioPlayer LORD_Theme_01; ISimpleAudioPlayer LORD_Theme_02; ISimpleAudioPlayer LORD_Theme_03; ISimpleAudioPlayer LORD_Theme_04;

        ISimpleAudioPlayer HP_Theme_00; ISimpleAudioPlayer HP_Theme_01; ISimpleAudioPlayer HP_Theme_02;

        ISimpleAudioPlayer Friends_Theme_00; ISimpleAudioPlayer Friends_Theme_01; ISimpleAudioPlayer Friends_Theme_02; ISimpleAudioPlayer Friends_Theme_03; ISimpleAudioPlayer Friends_Theme_04;

        ISimpleAudioPlayer Animal_Theme_00;

        ISimpleAudioPlayer Myth_Theme_00; ISimpleAudioPlayer Myth_Theme_01; ISimpleAudioPlayer Myth_Theme_02; ISimpleAudioPlayer Myth_Theme_03;


        public SelectedGameInfoPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            playselecteddeckButton.BackgroundColor = Color.FromHex(Global.PlaybuttonColor);
            playselecteddeckButton.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            deckinfoLabel.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            
        }
        protected override bool OnBackButtonPressed()
        {
            Navigation.PopToRootAsync();
            return true;
        }

        protected override void OnAppearing()
        {
            Global.CheckLanguage();
            Selecteddeckinfo();
            deckinfoLabel.Text = Global.DeckInfo;
            SelectedDeckPoster.Source = Global.DeckPoster;
            playselecteddeckButton.Text = Global.PlayButtonText;
            //SettingsButton.Text = Global.SettingsButtonText;
            ThemeSoundPlay(); //false - just play sounds (false would stop if any playing)



            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            allSounds.StopSounds(); // true - stops sounds if playing
            base.OnDisappearing();
        }

        //-------------------------------Theme sounds start------------------------------------------------------------------------------------------
        
        public void ThemeSoundPlay()
        {
            
            switch (Global.DeckNumber)
            {

                case 1:
                    allSounds.GOTsounds();
                    break;
                case 2:
                    allSounds.LoTRsounds();
                    break;
                case 3:
                    allSounds.HPsounds();
                    break;
                case 4:
                    allSounds.Friendssounds();
                    break;
                case 5:
                    allSounds.Animalssounds();
                    break;
                case 6:
                    allSounds.Mythsounds();
                    break;
                default:
                    break;
            }
        }
        //-------------------------------------Theme sounds end------------------------------------------------------------------------------------




        public async void Selecteddeckinfo()
        {
            switch (Global.DeckNumber)
            {
                case 1:

                    GotDeck.SetDeckInfo();
                    break;
                case 2:

                    LordDeck.SetDeckInfo();
                    break;
                case 3:

                    HarryDeck.SetDeckInfo();
                    break;
                case 4:

                    FriendsDeck.SetDeckInfo();
                    break;
                case 5:

                    Animals.SetDeckInfo();
                    break;
                case 6:

                    Myth.SetDeckInfo();
                    break;
                default:
                    await Navigation.PushAsync(new GameSelectionPage());
                    break;
            }
        }

        private async void PlayselecteddeckButton_Clicked(object sender, EventArgs e)
        {
            playselecteddeckButton.IsEnabled = false;

            await Navigation.PushAsync(new GameplayPage());
            Navigation.RemovePage(this);

            Sound make_play_now_sound = new Sound();
            make_play_now_sound.PlayTheGameSoundStream();
            make_play_now_sound.PlayTheGameSoundPlay();

        }

        //private async void SettingsButton_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new Settings());
        //}
    }
}