using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    public partial class MainPage : ContentPage
    {
        private static int _country;

        private const string BaseUrl = "https://open.spotify.com/user/spotifycharts/playlist/";
        private static readonly Dictionary<string, string> PopularChartsInCountry = new Dictionary<string, string>
        {
            ["us"] = "37i9dQZEVXbLRQDuF5jeBp",
            ["de"] = "37i9dQZEVXbJiZcmkrIHGU"

        };

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Device.OpenUri(_country++ % 2 == 0
                ? new Uri(BaseUrl + PopularChartsInCountry["en"])
                : new Uri(BaseUrl + PopularChartsInCountry["de"]));
        }
    }
}
