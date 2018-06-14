using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

using Xamarin.Forms;
using FFImageLoading.Forms;

namespace ArTai
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()
        {
            InitializeComponent();
            //Settings CheckSQL = new Settings();
            //CheckSQL.SQLConnection();



            MainPage = new NavigationPage(new GameSelectionPage())
            {
                //BarBackgroundColor = Color.FromHex(Global.ButtonBackColor),
                //BarTextColor = Color.FromHex(Global.ButtonTextWhiteColor),

            };

        }
        //public App(string databaseLocation)
        //{
        //    InitializeComponent();

        //    MainPage = new NavigationPage(new GameSelectionPage())
        //    {
        //        BarBackgroundColor = Color.FromHex(Global.ButtonBackColor),
        //        BarTextColor = Color.FromHex(Global.ButtonTextColor),
        //    };
        //    DatabaseLocation = databaseLocation;
        //}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }



    }
}
