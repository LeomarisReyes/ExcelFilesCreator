using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExcelFilesCreator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.ExportingEPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
