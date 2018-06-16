using SQLite;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ArTai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Settings : ContentPage
    {
        private SQLiteAsyncConnection _connection;
        Sound allSounds = new Sound();

        //public class Saved_Settings
        //{
        //    [SQLite.PrimaryKey, SQLite.AutoIncrement]
        //    public int StaticId { get; set; }
        //    public int Saved_Quantity { get; set; }
        //    public int Saved_Time { get; set; }
        //}


        public Settings()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            LanguagePicker.SelectedIndex = Global.LanguagePickerIndex;
            SetFields();
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



        private void SetFields()
        {
            //colors
            TimeStepperLabel.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            LanguagePickerLabel.TextColor = Color.FromHex((Global.ButtonTextWhiteColor));
            LanguagePicker.TextColor = Color.FromHex((Global.ButtonTextWhiteColor));
            QuestionStepperLabel.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);
            DownloadLabel.TextColor = Color.FromHex(Global.ButtonTextWhiteColor);

            LanguagePickerLabel.Text = Global.LanguagePickerLabel;
            LanguagePicker.Title = Global.LanguagePickerTitle;
            LanguagePicker.SelectedItem = Global.LanguagePickerItem;
            TimeStepper.Value = Global.CountDownTime;
            Questiontepper.Value = Global.QuestionQuantity;
            QuestionStepperLabel.Text = String.Format("{0} {1}", Global.QuestionQuantity, Global.QuestionslabelText);
            DownloadLabel.Text = Global.DownloadLabel;

            if (Global.CountDownTime <= 180)
            {
                TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
            }
            else
            {
                TimeStepperLabel.Text = "∞ sec";
            }
            DownloadSwitch.IsToggled = Global.DownloadImages;


        }


        //Time stepper---------------------------------------------------------------------------
        private void TimeStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Global.CountDownTime = Convert.ToInt32(TimeStepper.Value);
            if (Global.CountDownTime <= 180)
            {
                TimeStepperLabel.Text = String.Format("{0} sec", Global.CountDownTime);
            }
            else
            {
                TimeStepperLabel.Text = "∞ sec";
            }

            SaveToDB();

        }
        //Question stepper--------------------------------------------------------------------------
        private void Questiontepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Global.QuestionQuantity = Convert.ToInt32(Questiontepper.Value);
            QuestionStepperLabel.Text = String.Format("{0} {1}", Global.QuestionQuantity, Global.QuestionslabelText);

            SaveToDB();
        }



        private void LanguagePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            Global.LanguagePickerIndex = LanguagePicker.SelectedIndex;
            if (LanguagePicker.SelectedIndex == 0)
            {
                Global.LanguageSelectedID = 0;
                Global.CheckLanguage();
                SetFields();
            }
            else
            {
                Global.LanguageSelectedID = 1;
                Global.CheckLanguage();
                SetFields();
            }

            SaveToDB();

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            LanguagePicker.Focus();
        }

        private void DownloadSwitch_Toggled(object sender, ToggledEventArgs e)
        {
            Global.DownloadImages = DownloadSwitch.IsToggled;
            SaveToDB();
        }
        private async void SaveToDB()
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////Saving to DB
            var Save_TO_DB = new GameSelectionPage.Saved_Settings()
            {
                StaticId = 1,
                Saved_Quantity = Global.QuestionQuantity,
                Saved_Time = Global.CountDownTime,
                LanguageId = Global.LanguageSelectedID,
                DownloadImages = Global.DownloadImages,

            };
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
            await _connection.InsertOrReplaceAsync(Save_TO_DB);
        }
    }

}
