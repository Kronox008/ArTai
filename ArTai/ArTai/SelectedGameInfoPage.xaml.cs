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
            ThemeSoundPlay(); //crashing emulator, works in real divice



            base.OnAppearing();
        }
        protected override void OnDisappearing()
        {
            ThemeSoundsStop(); //crashing emulator, works in real divice
            base.OnDisappearing();
        }

        //-------------------------------Theme sound start------------------------------------------------------------------------------------------

        public void ThemeSoundPlay()
        {
            System.Random RandomNumber = new System.Random();

            switch (Global.DeckNumber)
            {

                case 1:
                    var GOTstream0 = GetStreamFromGOT_Theme0File("got_s1e5_pays_his_debts.wav");
                    GOT_Theme_00 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();        //Load selected deck theme sounds
                    GOT_Theme_00.Load(GOTstream0);

                    var GOTstream1 = GetStreamFromGOT_Theme1File("got_s1e7_win_or_die.wav");
                    GOT_Theme_01 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    GOT_Theme_01.Load(GOTstream1);

                    Stream GetStreamFromGOT_Theme0File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.GOT." + filename);

                        return stream;
                    }
                    Stream GetStreamFromGOT_Theme1File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.GOT." + filename);

                        return stream;
                    }



                    //Generating random number for selected deck (to choose specific 
                    int playthisNowGOT = RandomNumber.Next(0, 2);         // 2-1 = total streams




                    switch (playthisNowGOT)                              //Playing random theme sound form selected deck
                    {
                        case 0:
                            GOT_Theme_00.Volume = Global.ThemeSoundVolume;
                            GOT_Theme_00.Play();
                            break;
                        case 1:
                            GOT_Theme_01.Volume = Global.ThemeSoundVolume;
                            GOT_Theme_01.Play();
                            break;
                        default:
                            break;
                    }
                    break;
                case 2:
                    var LORDstream0 = GetStreamFromLord_Theme0File("king.wav");
                    LORD_Theme_00 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();        //Load selected deck theme sounds
                    LORD_Theme_00.Load(LORDstream0);

                    var LORDstream1 = GetStreamFromLord_Theme1File("death.wav");
                    LORD_Theme_01 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    LORD_Theme_01.Load(LORDstream1);

                    var LORDstream2 = GetStreamFromLord_Theme2File("tried.wav");
                    LORD_Theme_02 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    LORD_Theme_02.Load(LORDstream2);

                    var LORDstream3 = GetStreamFromLord_Theme3File("shallnotpass.wav");
                    LORD_Theme_03 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    LORD_Theme_03.Load(LORDstream3);

                    var LORDstream4 = GetStreamFromLord_Theme4File("task.wav");
                    LORD_Theme_04 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    LORD_Theme_04.Load(LORDstream4);

                    Stream GetStreamFromLord_Theme0File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.LoTR." + filename);

                        return stream;
                    }
                    Stream GetStreamFromLord_Theme1File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.LoTR." + filename);

                        return stream;
                    }
                    Stream GetStreamFromLord_Theme2File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.LoTR." + filename);

                        return stream;
                    }
                    Stream GetStreamFromLord_Theme3File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.LoTR." + filename);

                        return stream;
                    }
                    Stream GetStreamFromLord_Theme4File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.LoTR." + filename);

                        return stream;
                    }



                    //Generating random number for selected deck (to choose specific 
                    int playthisNowLord = RandomNumber.Next(0, 5);




                    switch (playthisNowLord)                              //Playing random theme sound form selected deck
                    {
                        case 0:
                            LORD_Theme_00.Volume = Global.ThemeSoundVolume;
                            LORD_Theme_00.Play();
                            break;
                        case 1:
                            LORD_Theme_01.Volume = Global.ThemeSoundVolume;
                            LORD_Theme_01.Play();
                            break;
                        case 2:
                            LORD_Theme_02.Volume = Global.ThemeSoundVolume;
                            LORD_Theme_02.Play();
                            break;
                        case 3:
                            LORD_Theme_03.Volume = Global.ThemeSoundVolume;
                            LORD_Theme_03.Play();
                            break;
                        case 4:
                            LORD_Theme_04.Volume = Global.ThemeSoundVolume;
                            LORD_Theme_04.Play();
                            break;

                        default:
                            break;
                    }
                    break;
                case 3:
                    var HPstream0 = GetStreamFromHP_Theme0File("avadakedavra.wav");
                    HP_Theme_00 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();        //Load selected deck theme sounds
                    HP_Theme_00.Load(HPstream0);

                    var HPstream1 = GetStreamFromHP_Theme1File("lumosmaxima.wav");
                    HP_Theme_01 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    HP_Theme_01.Load(HPstream1);

                    var HPstream2 = GetStreamFromHP_Theme2File("require.wav");
                    HP_Theme_02 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    HP_Theme_02.Load(HPstream2);

                    Stream GetStreamFromHP_Theme0File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.HP." + filename);

                        return stream;
                    }
                    Stream GetStreamFromHP_Theme1File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.HP." + filename);

                        return stream;
                    }
                    Stream GetStreamFromHP_Theme2File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.HP." + filename);

                        return stream;
                    }



                    //Generating random number for selected deck (to choose specific 
                    int playthisNowHP = RandomNumber.Next(0, 3);         // 2-1 = total streams




                    switch (playthisNowHP)                              //Playing random theme sound form selected deck
                    {
                        case 0:
                            HP_Theme_00.Volume = Global.ThemeSoundVolume;
                            HP_Theme_00.Play();
                            break;
                        case 1:
                            HP_Theme_01.Volume = Global.ThemeSoundVolume;
                            HP_Theme_01.Play();
                            break;
                        case 2:
                            HP_Theme_02.Volume = Global.ThemeSoundVolume;
                            HP_Theme_02.Play();
                            break;
                        default:
                            break;
                    }
                    break;
                case 4:
                    var Friendsstream0 = GetStreamFromFriends_Theme0File("couldie.mp3");
                    Friends_Theme_00 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();        //Load selected deck theme sounds
                    Friends_Theme_00.Load(Friendsstream0);

                    var Friendsstream1 = GetStreamFromFriends_Theme1File("howdoing.mp3");
                    Friends_Theme_01 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Friends_Theme_01.Load(Friendsstream1);

                    var Friendsstream2 = GetStreamFromFriends_Theme2File("ripped.mp3");
                    Friends_Theme_02 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Friends_Theme_02.Load(Friendsstream2);

                    var Friendsstream3 = GetStreamFromFriends_Theme3File("secrets.mp3");
                    Friends_Theme_03 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Friends_Theme_03.Load(Friendsstream3);

                    var Friendsstream4 = GetStreamFromFriends_Theme4File("smellyct.mp3");
                    Friends_Theme_04 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Friends_Theme_04.Load(Friendsstream4);



                    Stream GetStreamFromFriends_Theme0File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.friends." + filename);

                        return stream;
                    }
                    Stream GetStreamFromFriends_Theme1File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.friends." + filename);

                        return stream;
                    }
                    Stream GetStreamFromFriends_Theme2File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.friends." + filename);

                        return stream;
                    }
                    Stream GetStreamFromFriends_Theme3File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.friends." + filename);

                        return stream;
                    }
                    Stream GetStreamFromFriends_Theme4File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.friends." + filename);

                        return stream;
                    }





                    //Generating random number for selected deck (to choose specific 
                    int playthisNowFriends = RandomNumber.Next(0, 5);         // 2-1 = total streams




                    switch (playthisNowFriends)                              //Playing random theme sound form selected deck
                    {
                        case 0:
                            Friends_Theme_00.Volume = Global.ThemeSoundVolume;
                            Friends_Theme_00.Play();
                            break;
                        case 1:
                            Friends_Theme_01.Volume = Global.ThemeSoundVolume;
                            Friends_Theme_01.Play();
                            break;
                        case 2:
                            Friends_Theme_02.Volume = Global.ThemeSoundVolume;
                            Friends_Theme_02.Play();
                            break;
                        case 3:
                            Friends_Theme_03.Volume = Global.ThemeSoundVolume;
                            Friends_Theme_03.Play();
                            break;
                        case 4:
                            Friends_Theme_04.Volume = Global.ThemeSoundVolume;
                            Friends_Theme_04.Play();
                            break;

                        default:
                            break;
                    }
                    break;
                case 5:
                    var Animalstream0 = GetStreamFromAnimal_Theme0File("Narwhals.mp3");
                    Animal_Theme_00 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();        //Load selected deck theme sounds
                    Animal_Theme_00.Load(Animalstream0);


                    Stream GetStreamFromAnimal_Theme0File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.Animals." + filename);

                        return stream;
                    }

                    //Generating random number for selected deck (to choose specific 
                    int playthisNowAnimal = RandomNumber.Next(0, 2);         // 2-1 = total streams




                    switch (0)                              //Playing random theme sound form selected deck
                    {
                        case 0:
                            Animal_Theme_00.Volume = Global.ThemeSoundVolume;
                            Animal_Theme_00.Play();
                            break;
                        default:
                            break;
                    }
                    break;
                case 6:
                    var Mythstream0 = GetStreamFromMyth_Theme0File("arkantosarrive.wav");
                    Myth_Theme_00 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();        //Load selected deck theme sounds
                    Myth_Theme_00.Load(Mythstream0);

                    var Mythstream1 = GetStreamFromMyth_Theme1File("godpower.wav");
                    Myth_Theme_01 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Myth_Theme_01.Load(Mythstream1);

                    var Mythstream2 = GetStreamFromMyth_Theme2File("xsentinelbirth.wav");
                    Myth_Theme_02 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Myth_Theme_02.Load(Mythstream2);
                    var Mythstream3 = GetStreamFromMyth_Theme3File("xwin.wav");
                    Myth_Theme_03 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
                    Myth_Theme_03.Load(Mythstream3);

                    Stream GetStreamFromMyth_Theme0File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.Myth." + filename);

                        return stream;
                    }
                    Stream GetStreamFromMyth_Theme1File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.Myth." + filename);

                        return stream;
                    }
                    Stream GetStreamFromMyth_Theme2File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.Myth." + filename);

                        return stream;
                    }
                    Stream GetStreamFromMyth_Theme3File(string filename)
                    {
                        var assembly = typeof(App).GetTypeInfo().Assembly;

                        var stream = assembly.GetManifestResourceStream("ArTai.Sounds.Myth." + filename);

                        return stream;
                    }



                    //Generating random number for selected deck (to choose specific 
                    int playthisNowMyth = RandomNumber.Next(0, 4);         // 2-1 = total streams




                    switch (playthisNowMyth)                              //Playing random theme sound form selected deck
                    {
                        case 0:
                            Myth_Theme_00.Volume = Global.ThemeSoundVolume;
                            Myth_Theme_00.Play();
                            break;
                        case 1:
                            Myth_Theme_01.Volume = Global.ThemeSoundVolume;
                            Myth_Theme_01.Play();
                            break;
                        case 2:
                            Myth_Theme_02.Volume = Global.ThemeSoundVolume;
                            Myth_Theme_02.Play();
                            break;
                        case 3:
                            Myth_Theme_03.Volume = Global.ThemeSoundVolume;
                            Myth_Theme_03.Play();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }
        public void ThemeSoundsStop()
        {
            switch (Global.DeckNumber)
            {
                case 1:
                    if (GOT_Theme_00.IsPlaying)
                    {
                        GOT_Theme_00.Stop();
                    }
                    else if (GOT_Theme_01.IsPlaying)
                    {
                        GOT_Theme_01.Stop();
                    }
                    break;
                case 2:
                    if (LORD_Theme_00.IsPlaying)
                    {
                        LORD_Theme_00.Stop();
                    }
                    else if (LORD_Theme_01.IsPlaying)
                    {
                        LORD_Theme_01.Stop();
                    }
                    else if (LORD_Theme_02.IsPlaying)
                    {
                        LORD_Theme_02.Stop();
                    }
                    else if (LORD_Theme_03.IsPlaying)
                    {
                        LORD_Theme_03.Stop();
                    }
                    else if (LORD_Theme_04.IsPlaying)
                    {
                        LORD_Theme_04.Stop();
                    }
                    break;
                case 3:
                    if (HP_Theme_00.IsPlaying)
                    {
                        HP_Theme_00.Stop();
                    }
                    else if (HP_Theme_01.IsPlaying)
                    {
                        HP_Theme_01.Stop();
                    }
                    else if (HP_Theme_02.IsPlaying)
                    {
                        HP_Theme_02.Stop();
                    }
                    break;
                case 4:
                    if (Friends_Theme_00.IsPlaying)
                    {
                        Friends_Theme_00.Stop();
                    }
                    else if (Friends_Theme_01.IsPlaying)
                    {
                        Friends_Theme_01.Stop();
                    }
                    else if (Friends_Theme_02.IsPlaying)
                    {
                        Friends_Theme_02.Stop();
                    }
                    else if (Friends_Theme_03.IsPlaying)
                    {
                        Friends_Theme_03.Stop();
                    }
                    else if (Friends_Theme_04.IsPlaying)
                    {
                        Friends_Theme_04.Stop();
                    }
                    break;
                case 5:
                    if (Animal_Theme_00.IsPlaying)
                    {
                        Animal_Theme_00.Stop();
                    }
                    break;
                case 6:
                    if (Myth_Theme_00.IsPlaying)
                    {
                        Myth_Theme_00.Stop();
                    }
                    else if (Myth_Theme_01.IsPlaying)
                    {
                        Myth_Theme_01.Stop();
                    }
                    else if (Myth_Theme_02.IsPlaying)
                    {
                        Myth_Theme_02.Stop();
                    }
                    else if (Myth_Theme_03.IsPlaying)
                    {
                        Myth_Theme_03.Stop();
                    }
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