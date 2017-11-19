using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace TaxiMusic
{
    public partial class MainPage : ContentPage
    {
        bool isRecording;

        private static int _country;

        private const string BaseUrl = "https://open.spotify.com/user/spotifycharts/playlist/";
        private static readonly Dictionary<string, string> PopularChartsInCountry = new Dictionary<string, string>
        {
            ["us"] = "37i9dQZEVXbLRQDuF5jeBp",
            ["de"] = "37i9dQZEVXbJiZcmkrIHGU",
            ["fr"] = "37i9dQZEVXbIPWwFssbupI",

        };

        public MainPage()
        {
            InitializeComponent();

            App.AudioRecorder.AudioFilePath = Path.GetTempPath();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            //Device.OpenUri(_country++ % 2 == 0
            //    ? new Uri(BaseUrl + PopularChartsInCountry["en"])
            //    : new Uri(BaseUrl + PopularChartsInCountry["de"]));

            var button = (Button) sender;

            if (!isRecording)
            {
                string audioFileName = Guid.NewGuid().ToString();
                App.AudioRecorder.AudioFileName = audioFileName;
                App.AudioRecorder.StartRecord();
                button.Text = "Recording.......";
                isRecording = true;
            }
            else
            {
                button.Text = "Start Recording";
                App.AudioRecorder.StopRecord();
                isRecording = false;
            }
        }
    }
}
