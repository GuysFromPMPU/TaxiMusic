using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TaxiMusic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetectLanguage : ContentPage
    {
        private bool _isRecording;

        private static int _country;

        private const string BaseUrl = "https://open.spotify.com/user/spotifycharts/playlist/";
        private static readonly Dictionary<string, string> PopularChartsInCountry = new Dictionary<string, string>
        {
            ["us"] = "37i9dQZEVXbLRQDuF5jeBp",
            ["de"] = "37i9dQZEVXbJiZcmkrIHGU",
            ["fr"] = "37i9dQZEVXbIPWwFssbupI",

        };

        public DetectLanguage()
        {
            InitializeComponent();

            App.AudioRecorder.AudioFilePath = Path.GetTempPath();
            string audioFileName = Guid.NewGuid().ToString();
            App.AudioRecorder.AudioFileName = audioFileName;

            App.AudioRecorder.StartRecord();
            _isRecording = true;

            Task.Delay(3000).Wait();

            App.AudioRecorder.StopRecord();
            _isRecording = false;

            var file = File.ReadAllBytes(App.AudioRecorder.AudioFilePath + App.AudioRecorder.AudioFileName + ".wav");

            //Device.OpenUri(_country++ % 2 == 0
            //    ? new Uri(BaseUrl + PopularChartsInCountry["en"])
            //    : new Uri(BaseUrl + PopularChartsInCountry["de"]));
        }

        private Language GetSpeechLanguage(byte[] audioRecord)
        {
            return Language.English;
        }
    }
}