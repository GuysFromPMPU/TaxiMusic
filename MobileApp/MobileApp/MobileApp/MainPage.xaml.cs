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
        private static int _country = 0;
		public MainPage()
		{
			InitializeComponent();
		}

	    private void Button_OnClicked(object sender, EventArgs e)
	    {
	        Device.OpenUri(_country++ % 2 == 0
	            ? new Uri("https://open.spotify.com/user/spotifycharts/playlist/37i9dQZEVXbLRQDuF5jeBp")
	            : new Uri("https://open.spotify.com/user/spotifycharts/playlist/37i9dQZEVXbJiZcmkrIHGU"));
	    }
	}
}
