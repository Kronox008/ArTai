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

        // Theme Sounds start
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

            string soundName0 = "death.wav"; //crash
            string soundName1 = "reddawn.wav"; //works
            string soundName2 = "king.wav"; //crash
            string soundName3 = "shallnotpass.wav"; //works
            string soundName4 = "task.wav"; //works
            string soundName5 = "tried.wav"; //crash
            string soundPath  = "ArTai.Sounds.LoTR.";

           
            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            int soundNumber = RandomNumber.Next(0, 6);         // 2-1 = total streams
            

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
            string soundPath = "ArTai.Sounds.Myth.";

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
        // Theme Sounds end

        //GamePLay Sounds start
        public void StartGamesound()
        {
            string soundName0 = "glueenterworldbutton.mp3";
            string soundPath  = "ArTai.Sounds.";

            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            var StartGame = GetStream(soundPath, soundName0);
            allSounds.Load(StartGame); 

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();

        }
        public void Correctsound()
        {
            string soundName0 = "conjure_item.mp3";
            string soundPath = "ArTai.Sounds.";

            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            var Correct = GetStream(soundPath, soundName0);
            allSounds.Load(Correct); 

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();

        }
        public void Skipsound()
        {
            string soundName0 = "igplayerinvitedecline.mp3";
            string soundPath = "ArTai.Sounds.";

            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            var Skip = GetStream(soundPath, soundName0);
            allSounds.Load(Skip);

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();

        }
        public void Ticksound()
        {
            string soundName0 = "dot.mp3";
            string soundPath = "ArTai.Sounds.";

            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            var Tick = GetStream(soundPath, soundName0);
            allSounds.Load(Tick);

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();

        }
        //GamePlay Sounds end

        //Settings Sounds start
        public void OpenSettingssound()
        {
            string soundName0 = "chestOPEN.mp3";
            string soundPath = "ArTai.Sounds.";

            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            var OpenSettings = GetStream(soundPath, soundName0);
            allSounds.Load(OpenSettings);

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();

        }
        public void CloseSettingssound()
        {
            string soundName0 = "draenei_chest_anims_close.mp3";
            string soundPath = "ArTai.Sounds.";

            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            var CloseSettings = GetStream(soundPath, soundName0);
            allSounds.Load(CloseSettings);

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();

        }
        //Settings Sounds end

        //Score Screen Sounds start
        public void Scoressound()
        {
            string soundName0 = "lvlUP.mp3";
            string soundPath = "ArTai.Sounds.";

            allSounds = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

            var Score = GetStream(soundPath, soundName0);
            allSounds.Load(Score);

            allSounds.Volume = Global.SoundVolume;
            allSounds.Play();

        }
        //Score Screen Sounds end

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
