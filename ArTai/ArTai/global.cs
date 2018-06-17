using Plugin.SimpleAudioPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArTai
{
    public static class Global
    {
        public static int    DeckNumber      { get; set; }        // which one deck selected
        public static string DeckName        { get; set; }       //  selected deck name
        public static string DeckInfo        { get; set; }      //   information what is in this deck
        public static int    Deckcounter     { get; set; }     //    how many records in deck
        public static string DeckPoster      { get; set; }    //     deck poster string
        public static string DeckWallpaper   { get; set; }




        //Numbers for Questions to be selected
        public static int[] Numbers = new int[50];

        //----Question quantity--------------------------------------------------------------------------------------------------
        public static int    QuestionQuantity { get; set; }
        public static double Questionopacity = 0.7;
        public static double LabelBox = 0.7;
        public static bool   DownloadImages { get; set; }

        //Array to hold questions
        public static List<string> ShuffledQuestionList = new List<string>();
        public static string[,] ShuffledQuestion = new string[50, 2];

        //Array to hold correct or not

        public static int[] IsCorrect = new int[50];
        public static int[] IsGuessed = new int[50];
        public static int   IsCorrectCount { get; set; }




        //Timer------------------------------------------------------------------------------------------

        public static int CountDownTime           { get; set; }
        public static bool CountDownTimeIsRunning { get; set; }


        //-------colors-----------------------------------------------------------------------------------------

        public static string SkipColorHex = "#ff0033";
        public static string CorrectColorHex = "#50c878";
        public static string ButtonTextWhiteColor = "#ececec";
        public static string ButtonBackColor = "#FC4f1406";    // "#77d35400"; timer, question label, buttons, deck info....
        public static string TimersColors = "#d6d632";
        public static string QuestionBoxColor = "#2F4F4F";
        public static string PlaybuttonColor = "#50c878";


        //------------------SoundVOlume-------------------------------------------------------------------------

        public static double SoundVolume      { get; set; } = 0.9;
        public static double ThemeSoundVolume { get; set; } = 0.7;



        //--------------Languages?-----------------------------------------------------------------------------
        public static int LanguageSelectedID { get; set; }

        public static string SuggestionsText { get; set; }
        public static string SettingsButtonText  { get; set; }
        public static string InfoButtonText      { get; set; }
        public static string PlayButtonText      { get; set; }
        public static string QuestionslabelText  { get; set; }
        public static string HowToLabeltitle1    { get; set; }
        public static string HowToLabeltext1     { get; set; }
        public static string HowToLabeltitle2    { get; set; }
        public static string HowToLabeltext2     { get; set; }
        public static string ScoreLabeltext      { get; set; }
        public static string LanguagePickerLabel { get; set; }
        public static string LanguagePickerTitle { get; set; }
        public static int    LanguagePickerIndex { get; set; }
        public static string LanguagePickerItem  { get; set; }
        public static string CorrectButtonText   { get; set; }
        public static string SkipButtonText      { get; set; }
        public static string AgainButtonText     { get; set; }
        public static string DownloadLabel       { get; set; }



        public static void CheckLanguage()
        {
            if (LanguageSelectedID == 0)
            {
                SuggestionsText     = "What to improve?";
                SettingsButtonText  = "Settings";
                InfoButtonText      = "How to Play";
                PlayButtonText      = "Play";
                QuestionslabelText  = "questions";
                HowToLabeltitle1    = " Game 1:";
                HowToLabeltext1     = "Hold your phone before you. Your friend should try to tell you what person, thing or place is on the screen. " + 
                                      "Go to the next question with Volume up/down keys or buttons on the screen.";
                HowToLabeltitle2    = "";
                HowToLabeltext2     = "";
                ScoreLabeltext      = "Score: ";
                LanguagePickerLabel = "Language: ";
                LanguagePickerTitle = "Language";
                LanguagePickerIndex = 0;
                LanguagePickerItem  = "English";
                CorrectButtonText   = "Correct";
                SkipButtonText      = "Skip";
                AgainButtonText     = "Play again";
                DownloadLabel       = "Image downloading";

            }
            else
            {
                SuggestionsText     = "Ką patobulinti?";
                SettingsButtonText  = "Nustatymai";
                InfoButtonText      = "Kaip žaisti?";
                PlayButtonText      = "Pradėti";
                QuestionslabelText  = "klausimų";
                HowToLabeltitle1    = " 1 variantas:";
                HowToLabeltext1     = "Telefona laikyk prieš save. Aiškinantis žaidėjas/komanda bandys tau padėti atspėti," +
                                      " koks gi žmogus/personažas/įvykis/vieta/citata šįkart įsitaisius tavo telefone! " +
                                      "(Klausimai keičiami spaudžiant garsinimo / tildymo mygtukus ar mygtukus ekrane.";
                HowToLabeltitle2    = "";
                HowToLabeltext2     = "";
                ScoreLabeltext      = "Taškai: ";
                LanguagePickerLabel = "Kalba: ";
                LanguagePickerTitle = " Kalba  ";
                LanguagePickerIndex = 1;
                LanguagePickerItem  = "Lietuvių";
                CorrectButtonText   = "Teisingai";
                SkipButtonText      = "Praleisti";
                AgainButtonText     = "Dar kartą";
                DownloadLabel       = "Paveikslėlių naudojimas";
            }

        }








    }


}

