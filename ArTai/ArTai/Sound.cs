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

        ISimpleAudioPlayer allSounds;

        ISimpleAudioPlayer CorrectSoundPlayer;
        ISimpleAudioPlayer SkipSoundPlayer;
        ISimpleAudioPlayer TickSoundPlayer;
        ISimpleAudioPlayer ScoreSoundPlayer;
        ISimpleAudioPlayer SettingsSoundPlayer;
        ISimpleAudioPlayer SettingsClosingSoundPlayer;
        ISimpleAudioPlayer PlayGameSoundPlayer;

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
        //_------------------------------------------------------------------fixed___---------------------------------------------------------
        
        public void StopSounds()
        {
            if (allSounds.IsPlaying)
            {
                allSounds.Stop();
            }
        }
        public void GOTsounds()
        {
            System.Random RandomNumber = new System.Random();

            string soundName0 = "got_s1e5_pays_his_debts.wav";
            string soundName1 = "got_s1e7_win_or_die.wav";
            string soundPath  = "ArTai.Sounds.GOT.";
           
            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            int soundNumber = RandomNumber.Next(0, 2);         // 2-1 = total streams


            switch (soundNumber)
            {
                case 0:
                    var GOT0 = GetStream(soundPath, soundName0);
                    allSounds.Load(GOT0);
                    break;
                case 1:
                    var GOT1 = GetStream(soundPath, soundName1);
                    allSounds.Load(GOT1);
                    break;
                default:
                    break;
            }

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();
            
        }
        public void LoTRsounds()
        {
            System.Random RandomNumber = new System.Random();

            string soundName0 = "death.wav";
            string soundName1 = "king.wav";
            string soundName2 = "reddawn.wav";
            string soundName3 = "reddawn.wav";
            string soundName4 = "shallnotpass.wav";
            string soundName5 = "task.wav";
            string soundName6 = "tried.wav";
            string soundPath  = "ArTai.Sounds.LoTR.";

           
            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            int soundNumber = RandomNumber.Next(0, 7);         // 2-1 = total streams
            

            switch (soundNumber)
            {
                case 0:
                    var LoTR0 = GetStream(soundPath, soundName0);
                    allSounds.Load(LoTR0);
                    break;
                case 1:
                    var LoTR1 = GetStream(soundPath, soundName1);
                    allSounds.Load(LoTR1);
                    break;
                case 2:
                    var LoTR2 = GetStream(soundPath, soundName2);
                    allSounds.Load(LoTR2);
                    break;
                case 3:
                    var LoTR3 = GetStream(soundPath, soundName3);
                    allSounds.Load(LoTR3);
                    break;
                case 4:
                    var LoTR4 = GetStream(soundPath, soundName4);
                    allSounds.Load(LoTR4);
                    break;
                case 5:
                    var LoTR5 = GetStream(soundPath, soundName5);
                    allSounds.Load(LoTR5);
                    break;
                case 6:
                    var LoTR6 = GetStream(soundPath, soundName6);
                    allSounds.Load(LoTR6);
                    break;
                default:
                    break;
            }
            
            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();
        }
        public void HPsounds()
        {
            System.Random RandomNumber = new System.Random();

            string soundName0 = "avadakedavra.wav";
            string soundName1 = "lumosmaxima.wav";
            string soundName2 = "require.wav";
            string soundPath  = "ArTai.Sounds.HP.";

            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            int soundNumber = RandomNumber.Next(0, 3);         // 2-1 = total streams


            switch (soundNumber)
            {
                case 0:
                    var HP0 = GetStream(soundPath, soundName0);
                    allSounds.Load(HP0);
                    break;
                case 1:
                    var HP1 = GetStream(soundPath, soundName1);
                    allSounds.Load(HP1);
                    break;
                case 2:
                    var HP2 = GetStream(soundPath, soundName2);
                    allSounds.Load(HP2);
                    break;
                default:
                    break;
            }

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();

        }
        public void Friendssounds()
        {
            System.Random RandomNumber = new System.Random();

            string soundName0 = "couldie.wav";
            string soundName1 = "howdoing.wav";
            string soundName2 = "ripped.wav";
            string soundName3 = "secrets.wav";
            string soundName4 = "smellyct.wav";
            string soundPath  = "ArTai.Sounds.friends.";

            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            int soundNumber = RandomNumber.Next(0, 5);         // 2-1 = total streams


            switch (soundNumber)
            {
                case 0:
                    var FRIENDS0 = GetStream(soundPath, soundName0);
                    allSounds.Load(FRIENDS0);
                    break;
                case 1:
                    var FRIENDS1 = GetStream(soundPath, soundName1);
                    allSounds.Load(FRIENDS1);
                    break;
                case 2:
                    var FRIENDS2 = GetStream(soundPath, soundName2);
                    allSounds.Load(FRIENDS2);
                    break;
                case 3:
                    var FRIENDS3 = GetStream(soundPath, soundName3);
                    allSounds.Load(FRIENDS3);
                    break;
                case 4:
                    var FRIENDS4 = GetStream(soundPath, soundName4);
                    allSounds.Load(FRIENDS4);
                    break;
                default:
                    break;
            }

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();

        }
        public void Animalssounds()
        {
            System.Random RandomNumber = new System.Random();

            string soundName0 = "Narwhals.wav";
            string soundPath  = "ArTai.Sounds.Animals.";

            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            int soundNumber = 0;         // 2-1 = total streams


            switch (soundNumber)
            {
                case 0:
                    var ANIMALS0 = GetStream(soundPath, soundName0);
                    allSounds.Load(ANIMALS0);
                    break;
                default:
                    break;
            }

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();

        }
        public void Mythsounds()
        {
            System.Random RandomNumber = new System.Random();

            string soundName0 = "arkantosarrive.wav";
            string soundName1 = "godpower.wav";
            string soundName2 = "xsentinelbirth.wav";
            string soundName3 = "xwin.wav";
            string soundPath = "ArTai.Sounds.HP.";

            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            int soundNumber = RandomNumber.Next(0, 4);         // 2-1 = total streams


            switch (soundNumber)
            {
                case 0:
                    var MYTH0 = GetStream(soundPath, soundName0);
                    allSounds.Load(MYTH0);
                    break;
                case 1:
                    var MYTH1 = GetStream(soundPath, soundName1);
                    allSounds.Load(MYTH1);
                    break;
                case 2:
                    var MYTH2 = GetStream(soundPath, soundName2);
                    allSounds.Load(MYTH2);
                    break;
                case 3:
                    var MYTH3 = GetStream(soundPath, soundName3);
                    allSounds.Load(MYTH3);
                    break;
                default:
                    break;
            }

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();

        }


        private Stream GetStream(string soundPath, string soundName)
        {
            var powerStream = GetTheOneStream(soundPath, soundName);

            Stream GetTheOneStream(string filename, string soundname)
            {
                var assembly = typeof(App).GetTypeInfo().Assembly;

                var stream = assembly.GetManifestResourceStream(soundPath + soundname);

                return stream;
            }
            
            return (powerStream);
        }
        
    }
}
