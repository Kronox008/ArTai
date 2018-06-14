using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
//using Plugin.SimpleAudioPlayer.Abstractions;

namespace ArTai
{
    public class Sound
    {
        ISimpleAudioPlayer CorrectSoundPlayer;
        ISimpleAudioPlayer SkipSoundPlayer;
        ISimpleAudioPlayer TickSoundPlayer;
        ISimpleAudioPlayer ScoreSoundPlayer;
        ISimpleAudioPlayer SettingsSoundPlayer;
        ISimpleAudioPlayer SettingsClosingSoundPlayer;
        ISimpleAudioPlayer PlayGameSoundPlayer;
        //ISimpleAudioPlayer GOT_Theme0;
        //ISimpleAudioPlayer GOT_Theme1;
        private static double MasterVolume = Global.SoundVolume;
        public void CorrectSoundStream()
        {
            var stream = GetStreamFromCorrectFile("conjure_item.mp3");
            CorrectSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            CorrectSoundPlayer.Load(stream);


        }
        public void CorrectSoundPlay()
        {
            CorrectSoundPlayer.Volume = MasterVolume;
            CorrectSoundPlayer.Play();
        }


        Stream GetStreamFromCorrectFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("ArTai.Sounds." + filename);

            return stream;
        }
        //-------------------------------------------------------------------------------------------------------------------------

        public void SkipSoundStream()
        {
            var stream = GetStreamFromSkipFile("igplayerinvitedecline.mp3");
            SkipSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            SkipSoundPlayer.Load(stream);


        }
        public void SkipSoundPlay()
        {
            SkipSoundPlayer.Volume = MasterVolume;
            SkipSoundPlayer.Play();
        }


        Stream GetStreamFromSkipFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("ArTai.Sounds." + filename);

            return stream;
        }
        //-------------------------------------------------------------------------------------------------------------------------
        public void TickSoundStream()
        {
            var stream = GetStreamFromTickFile("dot.mp3");
            TickSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            TickSoundPlayer.Load(stream);


        }
        public void TickSoundPlay()
        {
            TickSoundPlayer.Volume = MasterVolume;
            TickSoundPlayer.Play();

        }



        Stream GetStreamFromTickFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("ArTai.Sounds." + filename);

            return stream;
        }
        //-------------------------------------------------------------------------------------------------------------------------

        public void ScoreSoundStream()
        {
            var stream = GetStreamFromScoreFile("lvlUP.mp3");
            ScoreSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            ScoreSoundPlayer.Load(stream);


        }
        public void ScoreSoundPlay()
        {
            ScoreSoundPlayer.Volume = MasterVolume;
            ScoreSoundPlayer.Play();

        }



        Stream GetStreamFromScoreFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("ArTai.Sounds." + filename);

            return stream;
        }
        //-------------------------------------------------------------------------------------------------------------------------
        public void SettingsSoundStream()
        {
            var stream = GetStreamFromSettingsFile("chestOPEN.mp3");
            SettingsSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            SettingsSoundPlayer.Load(stream);


        }
        public void SettingsSoundPlay()
        {
            SettingsSoundPlayer.Volume = MasterVolume;
            SettingsSoundPlayer.Play();

        }



        Stream GetStreamFromSettingsFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("ArTai.Sounds." + filename);

            return stream;
        }
        //-------------------------------------------------------------------------------------------------------------------------
        public void SettingsClosingSoundStream()
        {
            var stream = GetStreamFromSettingsCloseFile("draenei_chest_anims_close.mp3");
            SettingsClosingSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            SettingsClosingSoundPlayer.Load(stream);


        }
        public void SettingsCloseSoundPlay()
        {
            SettingsClosingSoundPlayer.Volume = MasterVolume;
            SettingsClosingSoundPlayer.Play();

        }



        Stream GetStreamFromSettingsCloseFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("ArTai.Sounds." + filename);

            return stream;
        }
        //-------------------------------------------------------------------------------------------------------------------------
        public void PlayTheGameSoundStream()
        {
            var stream = GetStreamFromPlayTheGameSoundFile("glueenterworldbutton.mp3");
            PlayGameSoundPlayer = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
            PlayGameSoundPlayer.Load(stream);


        }
        public void PlayTheGameSoundPlay()
        {
            PlayGameSoundPlayer.Volume = MasterVolume;
            PlayGameSoundPlayer.Play();

        }



        Stream GetStreamFromPlayTheGameSoundFile(string filename)
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;

            var stream = assembly.GetManifestResourceStream("ArTai.Sounds." + filename);

            return stream;
        }
    }
}
//-------------------------------------------------------------------------------------------------------------------------
////-------------------------------Theme sound start------------------------------------------------------------------------------------------

//public void ThemeSoundPlay( int SelectedDeckNumber)
//{

//    switch (SelectedDeckNumber)  
//    {

//        case 1:
//            var stream0 = GetStreamFromGOT_Theme0File("got_s1e5_pays_his_debts.wav");
//            GOT_Theme0 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();        //Load selected deck theme sounds
//            GOT_Theme0.Load(stream0);

//            var stream1 = GetStreamFromGOT_Theme1File("got_s1e7_win_or_die.wav");
//            GOT_Theme1 = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
//            GOT_Theme1.Load(stream1);

//                Stream GetStreamFromGOT_Theme0File(string filename)
//                {
//                    var assembly = typeof(App).GetTypeInfo().Assembly;

//                    var stream = assembly.GetManifestResourceStream("IsThis.Sounds.GOT." + filename);

//                    return stream;
//                }
//                Stream GetStreamFromGOT_Theme1File(string filename)
//                {
//                    var assembly = typeof(App).GetTypeInfo().Assembly;

//                    var stream = assembly.GetManifestResourceStream("IsThis.Sounds.GOT." + filename);

//                    return stream;
//                }



//                System.Random RandomNumber = new System.Random();  //Generating random number for selected deck (to choose specific 
//                int playthisNow = RandomNumber.Next(0, 2);         // 2-1 = total streams




//            switch (playthisNow)                              //Playing random theme sound form selected deck
//            {
//                case 0:
//                    GOT_Theme0.Volume = Global.ThemeSoundVolume;
//                    GOT_Theme0.Play();


//                    break;
//                case 1:
//                    GOT_Theme1.Volume = Global.ThemeSoundVolume;
//                    GOT_Theme1.Play();

//                    break;
//                default:
//                    break;
//            }
//            break;
//        default:
//            break;
//    }
//    }


//}
////-------------------------------------Theme sounds end------------------------------------------------------------------------------------




//}

