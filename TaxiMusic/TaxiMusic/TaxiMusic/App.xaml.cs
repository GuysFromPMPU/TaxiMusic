using TaxiMusic.Interfaces;
using Xamarin.Forms;

namespace TaxiMusic
{
    public partial class App : Application
    {
        public static IAudioRecorder AudioRecorder { get; set; }

        public App()
        {
            InitializeComponent();

            AudioRecorder = DependencyService.Get<IAudioRecorder>();

            MainPage = new MainPage();
        }

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
