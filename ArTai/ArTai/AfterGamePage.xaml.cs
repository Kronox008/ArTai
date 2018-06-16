using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ArTai.Decks;

namespace ArTai
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AfterGamePage : ContentPage
    {
        Sound allSounds = new Sound();

        public AfterGamePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);


            SelectedDeckPoster.Source   = Global.DeckPoster;
            MenuButton.BackgroundColor  = Color.FromHex(Global.ButtonBackColor);
            MenuButton.TextColor        = Color.FromHex(Global.ButtonTextWhiteColor);
            AgainButton.BackgroundColor = Color.FromHex(Global.PlaybuttonColor);
            AgainButton.TextColor       = Color.FromHex(Global.ButtonTextWhiteColor);
            AgainButton.Text            = Global.AgainButtonText;
            ScoreLabel.TextColor        = Color.FromHex(Global.CorrectColorHex);

            ScoreLabel.Text      = (String.Format("{1}{0}", Global.IsCorrectCount, Global.ScoreLabeltext));
            int TotalQuestion    = (Global.ShuffledQuestion.Length) / 2;
            Label[] arrayListing = new Label[TotalQuestion]; // declare the label object

            for (int i = 0; i < TotalQuestion; i++)
            {
                if ((Global.IsGuessed[i] == 1) && (Global.IsCorrect[i] == 1))
                {
                    arrayListing[i] = new Label() { Text = Global.ShuffledQuestion[i, 0], FontSize = 20, TextColor = Color.FromHex(Global.CorrectColorHex), HorizontalOptions = LayoutOptions.Center }; // create the label object 
                    XAMLSTACK.Children.Add(arrayListing[i]);  // adding the label
                }
                else if ((Global.IsGuessed[i] == 1) && (Global.IsCorrect[i] == 0))
                {
                    arrayListing[i] = new Label() { Text = Global.ShuffledQuestion[i, 0], FontSize = 20, TextColor = Color.FromHex(Global.SkipColorHex), HorizontalOptions = LayoutOptions.Center }; // create the label object 
                    XAMLSTACK.Children.Add(arrayListing[i]);  // adding the label
                }
            }


        }
        protected override void OnAppearing()
        {
            allSounds.Scoressound();

            base.OnAppearing();
        }

        protected override bool OnBackButtonPressed()
        {
            BackToRoot();
            return true;
        }
        private async void BackToRoot()
        {
            await Navigation.PopToRootAsync();
            //await Navigation.PushAsync(new GameSelectionPage());
        }

        private async void MenuButton_Clicked(object sender, EventArgs e)
        {
            MenuButton.IsEnabled = false;
            await Navigation.PopToRootAsync();
        }

        private async void AgainButton_Clicked(object sender, EventArgs e)
        {
            AgainButton.IsEnabled = false;
            SelectedGameInfoPage Randomize_again = new SelectedGameInfoPage();
            Randomize_again.Selecteddeckinfo();



            await Navigation.PushAsync(new GameplayPage());
            Navigation.RemovePage(this);
        }

    }
}